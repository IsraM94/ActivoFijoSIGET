Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Operaciones_SQLServer : Implements IDisposable
    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()
    Friend Function DataCenter() As String
        Return SQLConfiguration.EpdConnectionString.ToString
        REM Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function

    Private MSGERROR As String = "Fallo en la conexión con la base de datos, comuniquese con soporte técnico."
	Public Function GetInvoiceProjectTransaction(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_Project_Transaction_Select", conn)
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
    Public Function GetInventoryPurchaseOrders() As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetPurchaseOrders", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds, "info")
                dt = ds.Tables("info")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function
    Public Function GetSugeridos() As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetSuggestedProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds, "Sug")
            End Using
            dt = ds.Tables("Sug")
        Catch ex As SqlException

        Catch ex As Exception

        End Try
        Return dt
    End Function

#Region "Mantenimiento de Articulos"
    REM Mantenimiento de productos
    Public Function AddProducts(ByVal Id_Company_FK As Integer, ByVal Id_Customer_FK As Integer, ByVal Id_ProductCondition_FK As Integer, ByVal Id_Line_FK As Integer, ByVal Id_UnitMeasure_FK As Integer, ByVal IsExempt As Boolean, ByVal Name_Product As String, ByVal Description As String, ByVal BarCode As String, ByVal Price_Sale As Double, ByVal Price_LastPpurchase As Double, ByVal Price_Average As Double, ByVal ID_Category_FK As Integer, ByVal ID_Marca As Integer, ByVal picture As String, ByVal IS_Recipe As Boolean, ByVal IS_RawMaterial As Boolean, ByVal IS_Mixed As Boolean, ByVal IS_FinalProduct As Boolean, ByVal IS_SubProduct As Boolean, ByVal ID_ConversionUnit_FK As Long, ByVal NumberPurchase As String) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventoryAddProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company_FK", Id_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_Customer_FK", Id_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_ProductCondition_FK", Id_ProductCondition_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_Line_FK", Id_Line_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_UnitMeasure_FK", Id_UnitMeasure_FK)
                da.SelectCommand.Parameters.AddWithValue("@IsExempt", IsExempt)
                da.SelectCommand.Parameters.AddWithValue("@Name_Product", Name_Product)
                da.SelectCommand.Parameters.AddWithValue("@Description", Description)
                da.SelectCommand.Parameters.AddWithValue("@BarCode", BarCode)
                da.SelectCommand.Parameters.AddWithValue("@Price_Sale", Price_Sale)
                da.SelectCommand.Parameters.AddWithValue("@Price_LastPpurchase", Price_LastPpurchase)
                da.SelectCommand.Parameters.AddWithValue("@Price_Average", Price_Average)
                da.SelectCommand.Parameters.AddWithValue("@ID_Category_FK", ID_Category_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                da.SelectCommand.Parameters.AddWithValue("@Picture", picture)
                da.SelectCommand.Parameters.AddWithValue("@IS_Recipe", IS_Recipe)
                da.SelectCommand.Parameters.AddWithValue("@IS_RawMaterial", IS_RawMaterial)
                da.SelectCommand.Parameters.AddWithValue("@IS_Mixed", IS_Mixed)
                da.SelectCommand.Parameters.AddWithValue("@IS_FinalProduct", IS_FinalProduct)
                da.SelectCommand.Parameters.AddWithValue("@IS_SubProduct", IS_SubProduct)
                da.SelectCommand.Parameters.AddWithValue("@ID_ConversionUnit_FK", ID_ConversionUnit_FK)
                da.SelectCommand.Parameters.AddWithValue("@Number_Purchase", NumberPurchase)
                da.Fill(ds, "Add")
                resp = ds.Tables("Add").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error al conectar con el servidor SQL, por favor contacte a Soporte técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error, por favor contacte a Soporte técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return resp
    End Function

    Public Function SetProducts(ByVal Id_Product As Integer, ByVal Id_Company_FK As Integer, ByVal Id_Customer_FK As Integer, ByVal Id_ProductCondition_FK As Integer, ByVal Id_Line_FK As Integer, ByVal Id_UnitMeasure_FK As Integer, ByVal IsExempt As Boolean, Name_Product As String, ByVal Description As String, ByVal BarCode As String, ByVal Price_Sale As Double, ByVal Price_LastPpurchase As Double, ByVal Price_Average As Double, ByVal ID_Category_FK As Integer, ByVal ID_Marca As Integer, ByVal Picture As String, ByVal IS_Recipe As Boolean, ByVal IS_RawMaterial As Boolean, ByVal IS_Mixed As Boolean, ByVal IS_FinalProduct As Boolean, ByVal IS_SubProduct As Boolean, ByVal ID_ConversionUnit_FK As Long, ByVal NumberPurchase As String) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventorySetProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Product", Id_Product)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company_FK", Id_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_Customer_FK", Id_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_ProductCondition_FK", Id_ProductCondition_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_Line_FK", Id_Line_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_UnitMeasure_FK", Id_UnitMeasure_FK)
                da.SelectCommand.Parameters.AddWithValue("@IsExempt", IsExempt)
                da.SelectCommand.Parameters.AddWithValue("@Name_Product", Name_Product)
                da.SelectCommand.Parameters.AddWithValue("@Description", Description)
                da.SelectCommand.Parameters.AddWithValue("@BarCode", BarCode)
                da.SelectCommand.Parameters.AddWithValue("@Price_Sale", Price_Sale)
                da.SelectCommand.Parameters.AddWithValue("@Price_LastPpurchase", Price_LastPpurchase)
                da.SelectCommand.Parameters.AddWithValue("@Price_Average", Price_Average)
                da.SelectCommand.Parameters.AddWithValue("@ID_Category_FK", ID_Category_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                da.SelectCommand.Parameters.AddWithValue("@Picture", Picture)
                da.SelectCommand.Parameters.AddWithValue("@IS_Recipe", IS_Recipe)
                da.SelectCommand.Parameters.AddWithValue("@IS_RawMaterial", IS_RawMaterial)
                da.SelectCommand.Parameters.AddWithValue("@IS_Mixed", IS_Mixed)
                da.SelectCommand.Parameters.AddWithValue("@IS_FinalProduct", IS_FinalProduct)
                da.SelectCommand.Parameters.AddWithValue("@IS_SubProduct", IS_SubProduct)
                da.SelectCommand.Parameters.AddWithValue("@ID_ConversionUnit_FK", ID_ConversionUnit_FK)
                da.SelectCommand.Parameters.AddWithValue("@Number_Purchase", NumberPurchase)

                da.Fill(ds, "Add")
                resp = ds.Tables("Add").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Ocurrio un error al conectar con el servidor SQL, por favor contacte a Soporte técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error, por favor contacte a Soporte técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return resp
    End Function

    Public Function AddProducts(ByVal ID_Provider As Integer, ByVal Description As String, ByVal BarCode As String, ByVal ID_Unit As Integer _
                                , ByVal PurchasePrice As Double, ByVal PriceSale As Double, ByVal Inventory As Double)
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Provider", ID_Provider)
                da.SelectCommand.Parameters.AddWithValue("@Description", Description)
                da.SelectCommand.Parameters.AddWithValue("@BarCode", BarCode)
                da.SelectCommand.Parameters.AddWithValue("@ID_Unit", ID_Unit)
                da.SelectCommand.Parameters.AddWithValue("@PurchasePrice", PurchasePrice)
                da.SelectCommand.Parameters.AddWithValue("@PriceSale", PriceSale)
                da.SelectCommand.Parameters.AddWithValue("@Inventory", Inventory)
                da.Fill(ds, "AddProduct")
                resp = ds.Tables("AddProduct").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_DeleteProducts(ByVal ID_Company As Long, ByVal ID_Product As Long) As Integer
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_DeleteProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_Product", ID_Product)
                da.Fill(ds, "delete")
                If ds.Tables.Count > 0 Then
                    dt = ds.Tables(0)
                    If dt.Rows.Count > 0 Then
                        resp = dt.Rows(0).Item("resp")
                    End If
                End If
            End Using
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function


    Public Function GetProviders(ByVal ID_Company As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Generic_GetCustomerMaster", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.Fill(ds, "AddProduct")
                dt = ds.Tables("AddProduct")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function GetUnitMeasure(ByVal ID_Company As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_GenericGetUnitMeasure", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company_FK", ID_Company)
                da.Fill(ds, "UnitMeasure")
            End Using
            dt = ds.Tables("UnitMeasure")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function GetTypeProduct() As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Generic_GetProductCondition", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
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

    Public Function GetCategory(ByVal ID_Company As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetCategory", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.Fill(ds, "Category")
            End Using
            dt = ds.Tables("Category")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function
    Public Function GetCategory(ByVal ID_Company As Integer, ByVal busqueda As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetCategory_LIKE", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda)
                da.Fill(ds, "Category")
            End Using
            dt = ds.Tables("Category")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function ERP_SP_Inventory_GetReason() As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetReason", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                da.Fill(ds, "Reason")
            End Using
            dt = ds.Tables("Reason")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function ERP_SP_Inventory_GetReason(ByVal busqueda As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GetReason_Like", New SqlClient.SqlConnection(connStr))

                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda)
                da.Fill(ds, "Reason")
            End Using
            dt = ds.Tables("Reason")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function GetLine(ByVal ID_Company As Integer, ByVal ID_Category As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_GetInventoryLine", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Category_Fk", ID_Category)
                da.Fill(ds, "Line")
            End Using
            dt = ds.Tables("Line")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function GetMarca(ByVal ID_Company As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_GetInventoryMarca", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", _ID_Company)
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

    Public Function GetGenericProduct(ByVal ID_Company As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventoryGetProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.Fill(ds, "Line")
            End Using
            dt = ds.Tables("Line")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function DelGenericProduct(ByVal ID As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[SP_ERP_InventoryDelProducts]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Product", SqlDbType.BigInt).Value = ID
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            'Process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            'Process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SearchProducts(ByVal ID_Company As Integer, ByVal Search As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventorySearchProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Busqueda", Search)
                da.Fill(ds, "AddProduct")
                dt = ds.Tables("AddProduct")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

#Region "Log Exception"
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
            MessageBox.Show("Ocurrio un error al conectar con el servidor SQL, por favor contacte a Soporte técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error, por favor contacte a Soporte técnico", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
    End Sub
#End Region


    Public Function CreateLot(ByVal Id_Flow As Integer, ByVal Descripcion As String, ByVal Fecha_Inicio As Date, ByVal Id_lote As Integer, ByVal ID_Stowage_FK As Long) As DataSet
        Dim ds As New DataSet("Datos")
        Dim resp As String = ""
        Try

            'Informacion General del Proceso
            Using da As New SqlDataAdapter("ERP_Prod_SP_Insert_Lot", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.Add("@id_flow", SqlDbType.BigInt).Value = Id_Flow
                da.SelectCommand.Parameters.Add("@Descripcion_Name", SqlDbType.VarChar).Value = Descripcion
                da.SelectCommand.Parameters.Add("@Id_Lot", SqlDbType.VarChar).Value = Id_lote
                da.SelectCommand.Parameters.Add("@Fecha_Inicio", SqlDbType.Date).Value = Fecha_Inicio
                da.SelectCommand.Parameters.Add("@Initial_Inventory", SqlDbType.VarChar).Value = 0
                da.SelectCommand.Parameters.Add("@Final_Inventory", SqlDbType.Decimal).Value = 0
                da.SelectCommand.Parameters.Add("@Quantity", SqlDbType.Float).Value = 0
                da.SelectCommand.Parameters.Add("@User_Create", SqlDbType.VarChar).Value = My.User.Name
                da.SelectCommand.Parameters.Add("@Date_Create", SqlDbType.Date).Value = Date.Now.ToString("yyyy-M-d")
                da.SelectCommand.Parameters.Add("@ID_Stowage_FK", SqlDbType.BigInt).Value = ID_Stowage_FK
                da.Fill(ds, "CreateLot")
                Return ds
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            MessageBox.Show("Error al crear el Lote", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As IndexOutOfRangeException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            MessageBox.Show("Error al crear el Lote", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            MessageBox.Show("Error al crear el Lote", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function



    Public Function GetInfoFlow(ByVal Activo As Boolean) As DataSet
        Dim ds As New DataSet("Datos")
        Try

            'Informacion General del Proceso
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_InfoFlow", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.Add("@Activo", SqlDbType.VarChar).Value = Activo
                da.Fill(ds, "Lot")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            MessageBox.Show("Error al mostrar la informacion del proceso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As IndexOutOfRangeException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            MessageBox.Show("Error al mostrar la informacion del proceso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
            MessageBox.Show("Error al mostrar la informacion del proceso", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function

#End Region
    Public Function GetInventoryProductsOnAlert(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Inventory_ProductsOnAlert", conn)
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
    Public Function Get_AnimalsToSacrifice(ByVal CantidadS As Long) As DataSet
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_PROD_AnimalsToSacrifice", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CantidadS", SqlDbType.Float).Value = CantidadS
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Datos")
                            Return ds
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataSet("datos")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



#Region "Recetas"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ID_Company">ID empresa</param>
    ''' <param name="Word">palabra para busqueda ya tiene incluido "%"</param>
    ''' <param name="Type">tipo de condicion: 1= productos sin receta, 2: productos con receta Asiganda</param>
    ''' <returns>tabla con productos </returns>
    Public Function ERP_Inventory_GetProducts_Recipes(ByVal ID_Company As Integer, ByVal Word As String, ByVal Type As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_GetProducts_Recipes", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Word", Word)
                da.SelectCommand.Parameters.AddWithValue("@Type", Type)
                da.Fill(ds, "AddProduct")
                dt = ds.Tables("AddProduct")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function
    Public Function ERP_Inventory_ADDRecipe(ByVal ID_Recipe_FK As Long, ByVal ID_Product_FK As Long, ByVal Quantity As Double) As Integer
        Dim dt As New DataTable
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_ADDRecipe", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Recipe_FK", ID_Recipe_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product_FK", ID_Product_FK)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.Fill(ds, "AddProduct")
                dt = ds.Tables("AddProduct")
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        resp = dt.Rows(0).Item("resp")
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function ERP_Inventory_GetIngredientsRecipe(ByVal ID_Recipe As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_GetIngredientsRecipe", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Recipe_FK", ID_Recipe)
                da.Fill(ds, "AddProduct")
                dt = ds.Tables("AddProduct")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function
    Public Function ERP_Inventory_Get_StockProductsForRecipe(ByVal ID_Stowage As Long, ByVal ID_Recipe As Long, ByVal AmountRequested As Decimal) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Get_StockProductsForRecipe", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage", ID_Stowage)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product", ID_Recipe)
                da.SelectCommand.Parameters.AddWithValue("@AmountRequested", AmountRequested)
                da.Fill(ds, "datos")
                dt = ds.Tables("datos")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function ERP_Inventory_UpdateIngredientsRecipe(ByVal ID_Recipe_FK As Long, ByVal Quantity As Double) As Integer
        Dim dt As New DataTable
        Dim resp As Integer = 0
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_UpdateIngredientsRecipe", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Ingredients", ID_Recipe_FK)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.Fill(ds, "update")
                dt = ds.Tables("update")
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        resp = dt.Rows(0).Item("resp")
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function


#End Region

#Region "Entrada y salida de inventario(Configuracion de Bodegas)"

    Public Function SP_ERP_Inventory_UpdateMaximusAndMinimous(ByVal ID_Stowage_FK As Long, ByVal Id_Product_FK As Long, ByVal Top_Product As Double, ByVal Least_Product As Double) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_UpdateMaximusAndMinimous", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_Product_FK", Id_Product_FK)
                da.SelectCommand.Parameters.AddWithValue("@Top_Product", Top_Product)
                da.SelectCommand.Parameters.AddWithValue("@Least_Product", Least_Product)
                da.Fill(ds, "inventory")
                dt = ds.Tables("inventory")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_GetLocation(ByVal ID_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetLocation", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.Fill(ds, "getLocation")
                dt = ds.Tables("getLocation")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_GetStowage_ByLocation(ByVal ID_Location As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetStowage_ByLocation", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Location", ID_Location)
                da.Fill(ds, "Stowage")
                dt = ds.Tables("Stowage")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_Add_InventoryHeader(ByVal ID_Company_FK As Long, ByVal ID_Customer_FK As Long, ByVal ID_Stowage_FK As Long, ByVal InvoiceNumber As String, ByVal WayToPay As String,
                                                         ByVal InvoiceDate As Date, ByVal IS_Lot As Boolean, ByVal ID_Lot_FK As Long, ByVal ID_Outlet_FK As Long, ByVal Ordencompras As Long, ByVal tipoCompra As String, ByVal ModalidadCompra As String,
                                                         Optional UpdateData As Boolean = False, Optional Id_HeaderUpdate As Integer = 0, Optional is_close As Integer = 0) As Integer
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Add_InventoryHeader", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@InvoiceNumber", InvoiceNumber)
                da.SelectCommand.Parameters.AddWithValue("@WayToPay", WayToPay)
                da.SelectCommand.Parameters.AddWithValue("@InvoiceDate", InvoiceDate)
                da.SelectCommand.Parameters.AddWithValue("@IS_Lot", IS_Lot)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot_FK", ID_Lot_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Outlet_FK", ID_Outlet_FK)
                da.SelectCommand.Parameters.AddWithValue("@Ordencompras", Ordencompras)
                da.SelectCommand.Parameters.AddWithValue("@tipoCompra", tipoCompra)
                da.SelectCommand.Parameters.AddWithValue("@ModalidadCompra", ModalidadCompra)
                da.SelectCommand.Parameters.AddWithValue("@UpdateData", Convert.ToInt32(UpdateData))
                da.SelectCommand.Parameters.AddWithValue("@Id_HeaderUpdate", Id_HeaderUpdate)
                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_InsertLot(ByVal Number_Lot As String, ByVal ExpirationDate As DateTime, ByVal ID_Stowage As Long, ByVal UpdateEntrada As Boolean) As Long
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_InsertLot", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Number_Lot", Number_Lot)
                da.SelectCommand.Parameters.AddWithValue("@ExpirationDate", ExpirationDate)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage)
                da.SelectCommand.Parameters.AddWithValue("@UpdateEntrada", Convert.ToInt32(UpdateEntrada))


                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function ERP_SP_Inventory_Report_Lot(ByVal ID_Stowage As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_Report_Lot", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage)
                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function SP_ERP_Inventory_Add_Inventory(ByVal ID_Header As Long, ByVal ID_Product_FK As Long, ByVal ID_Stowage_FK As Long,
                                                   ByVal Quantity As Double, ByVal Price As Double, ByVal UnidadMedida As Long, ByVal IS_Unitario As Integer,
                                                   ByVal IS_IVA As Integer, ByVal ID_Lot As Long, Optional FechaVencimiento As String = "") As Integer
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Add_Inventory", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Header", ID_Header)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product_FK", ID_Product_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.SelectCommand.Parameters.AddWithValue("@Price", Price)
                da.SelectCommand.Parameters.AddWithValue("@UnidadMedida", UnidadMedida)
                da.SelectCommand.Parameters.AddWithValue("@IS_Unitario", IS_Unitario)
                da.SelectCommand.Parameters.AddWithValue("@IS_IVA", IS_IVA)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.SelectCommand.Parameters.AddWithValue("@FechaVencimiento", Convert.ToDateTime(FechaVencimiento))

                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_CleanData(ByVal ID_Header As Long) As Integer
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_CleanData", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", _ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Header", ID_Header)

                da.Fill(ds, "CleanData")
                resp = 1
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function


    Public Function SP_ERP_Inventory_Add_InventoryTemp(ByVal ID_Header As Long, ByVal ID_Product_FK As Long, ByVal ID_Stowage_FK As Long,
                                                   ByVal Quantity As Double, ByVal Price As Double, ByVal UnidadMedida As Long, ByVal IS_Unitario As Integer,
                                                   ByVal IS_IVA As Integer, ByVal ID_Lot As Long, Optional FechaVencimiento As String = "") As Integer
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Add_InventoryTemp", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Header", ID_Header)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product_FK", ID_Product_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.SelectCommand.Parameters.AddWithValue("@Price", Price)
                da.SelectCommand.Parameters.AddWithValue("@UnidadMedida", UnidadMedida)
                da.SelectCommand.Parameters.AddWithValue("@IS_Unitario", IS_Unitario)
                da.SelectCommand.Parameters.AddWithValue("@IS_IVA", IS_IVA)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.SelectCommand.Parameters.AddWithValue("@FechaVencimiento", Convert.ToDateTime(FechaVencimiento))


                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function


    Public Function ERP_Inventory_GetProducts_Stowage(ByVal Id_Company As Long, ByVal Word As String, ByVal ID_Stowage_FK As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_GetProducts_Stowage", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Word", Word)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.Fill(ds, "Products")
                dt = ds.Tables("Products")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function ERP_Inventory_GetProducts_Kardex(ByVal Id_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Get_ProductFindKardex", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.Fill(ds, "Products")
                dt = ds.Tables("Products")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function ERP_Inventory_GetProducts_Category(ByVal Id_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Get_ProductFindCategory", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.Fill(ds, "Products")
                dt = ds.Tables("Products")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function ERP_Inventory_GetProducts_Stowage(ByVal Id_Company As Long, ByVal id_EntryHeader As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_EntryReport", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_EntryHeader", id_EntryHeader)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function Inventory_OutputReport(ByVal Id_Company As Long, ByVal id_OutputHeader As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_OutputReport", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_OutputHeader", id_OutputHeader)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function Inventory_OutputRejection(ByVal id_OutputHeader As Long, ByVal Comentario As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_OutputRejection", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_OutputHeader", id_OutputHeader)
                da.SelectCommand.Parameters.AddWithValue("@Comentario", Comentario)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_Output_InventoryHeader(ByVal ID_Stowage_FK As Long, ByVal ID_Outlet_FK As Long, ByVal Comments As String, ByVal Id_OutputUpdate As Integer) As Long
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Output_InventoryHeader", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Outlet_FK", ID_Outlet_FK)
                da.SelectCommand.Parameters.AddWithValue("@Comments", Comments)
                da.SelectCommand.Parameters.AddWithValue("@Id_OutputUpdate", Id_OutputUpdate)

                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_Output_InventoryHeaderBodega(ByVal ID_Stowage_FK As Long, ByVal ID_Outlet_FK As Long, ByVal Comments As String,
                                                                  ByVal StowageOfDestination_FK As Long, ByVal Id_OutputUpdate As Integer) As Long
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Output_InventoryHeader", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Outlet_FK", ID_Outlet_FK)
                da.SelectCommand.Parameters.AddWithValue("@Comments", Comments)
                da.SelectCommand.Parameters.AddWithValue("@StowageOfDestination_FK", StowageOfDestination_FK)
                da.SelectCommand.Parameters.AddWithValue("@Id_OutputUpdate", Id_OutputUpdate)

                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_Output_Aproved(ByVal ID_Stowage_FK As Long, ByVal ID_Outlet_FK As Long) As Long
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Output_Aproved", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Output", ID_Outlet_FK)
                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function


    Public Function SP_ERP_Inventory_Output_InventoryDetails(ByVal ID_Company_FK As Long, ByVal ID_Output_FK As Long, ByVal ID_Stowage_FK As Long, ByVal ID_Product_FK As Long, ByVal Quantity As Double) As Long
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Output_InventoryDetails", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Output_FK", ID_Output_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product_FK", ID_Product_FK)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function


    Public Function SP_ERP_Inventory_Output_InventoryDetailsTemp(ByVal ID_Company_FK As Long, ByVal ID_Output_FK As Long, ByVal ID_Stowage_FK As Long, ByVal ID_Product_FK As Long, ByVal Quantity As Double) As Long
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Output_InventoryDetailsTEMP", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Output_FK", ID_Output_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product_FK", ID_Product_FK)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")
                        If dt.Rows.Count > 0 Then
                            resp = dt.Rows(0).Item("resp")
                        End If
                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_Get_StowageAvailableTransfer(ByVal ID_Stowage As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Dim resp As Long = 0
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Get_StowageAvailableTransfer", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage", ID_Stowage)
                da.Fill(ds, "Stowage")
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dt = ds.Tables("Stowage")

                    End If
                End If
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

#End Region

#Region "Mantenimiento Catalogo de salidas"
    Public Function SP_ERP_Inventory_GetOutletCatalog(ByVal Id_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetOutletCatalog", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_company", Id_Company)
                da.Fill(ds, "Catalog Outputs")
                dt = ds.Tables("Catalog Outputs")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_GetOutletCatalogFiltro(ByVal Id_Company As Long, ByVal Tipo As Boolean) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetOutletCatalogFiltro", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Tipo", Tipo)
                da.Fill(ds, "Catalog Outputs")
                dt = ds.Tables("Catalog Outputs")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_GetOutletProcess(ByVal Id_Company As Long, ByVal Busquedad As String, ByVal TipoBusquedad As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetOutletProcess", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Busquedad", Busquedad)
                da.SelectCommand.Parameters.AddWithValue("@TipoBusquedad", TipoBusquedad)
                da.Fill(ds, "Outputs")
                dt = ds.Tables("Outputs")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_GetOutletProcessApro(ByVal Id_HeaderOutlet As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetOutletProcessApro", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_HeaderOutlet", Id_HeaderOutlet)
                da.Fill(ds, "Outputs")
                dt = ds.Tables("Outputs")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function SP_ERP_Inventory_GetOutletCatalog(ByVal Id_Company As Long, ByVal busqueda As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_GetOutletCatalog_LIKE", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@busqueda", busqueda)
                da.Fill(ds, "Catalog Outputs")
                dt = ds.Tables("Catalog Outputs")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_InsertOutletCatalog(ByVal id_Company As Long, ByVal description As String, ByVal IS_Entry As Boolean) As String
        Dim resp As String
        Dim ds As New DataSet("AddOutletCatalog")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_InsertOutletCatalog", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.SelectCommand.Parameters.AddWithValue("@IS_Entry", IS_Entry)
                da.Fill(ds, "AddOutletCatalog")
                resp = ds.Tables("AddOutletCatalog").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_UpdateOutletCatalog(ByVal id_Company As Long, ByVal id_outletCatalog As Long, ByVal description As String, ByVal IS_Entry As Boolean) As String
        Dim resp As String
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_UpdateOutletCatalog", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_OutletCatalog", id_outletCatalog)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Description", description)
                da.SelectCommand.Parameters.AddWithValue("@IS_Entry", IS_Entry)
                da.Fill(ds, "SetOutletCatalog")
                resp = ds.Tables("SetOutletCatalog").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function SP_ERP_Inventory_DeleteOutletCatalog(ByVal id_Company As Long, ByVal id_outletCatalog As Long) As String
        Dim resp As String
        Dim ds As New DataSet("DeleteOutletCatalog")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_DeleteOutletCatalog", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_outletCatalog", id_outletCatalog)
                da.SelectCommand.Parameters.AddWithValue("@id_Company", id_Company)
                da.Fill(ds, "DeleteOutletCatalog")
                resp = ds.Tables("DeleteOutletCatalog").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function



#End Region

#Region "Produccion Salida de productos de flow"
    Public Function ERP_Prod_ConsumptionFlowproducts_add(ByVal Id_Production As Long, ByVal Id_Process As Long, ByVal id_product As Long, ByVal ID_Scheduled As Long, ByVal TotalProduct As Decimal) As String
        Dim resp As String = "Error"
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ConsumptionFlowproducts_add", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Production", Id_Production)
                da.SelectCommand.Parameters.AddWithValue("@Id_Process", Id_Process)
                da.SelectCommand.Parameters.AddWithValue("@id_product", id_product)
                da.SelectCommand.Parameters.AddWithValue("@ID_Scheduled", ID_Scheduled)
                da.SelectCommand.Parameters.AddWithValue("@TotalProduct", TotalProduct)
                da.Fill(ds, "tabla")
                resp = "OK|" & ds.Tables("tabla").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
    Public Function ERP_Prod_ConsumptionFlowproducts_update(ByVal Id_Transaction As Long) As String
        Dim resp As String = "Error"
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ConsumptionFlowproducts_update", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Transaction", Id_Transaction)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
    Public Function ERP_Prod_ConsumptionFlowproducts_Select() As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ConsumptionFlowproducts_Select", New SqlClient.SqlConnection(connStr))
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function


#End Region

#Region "Sacrificio"
    Public Function ERP_Prod_SP_Select_AnimalsLot(ByVal id_lot As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_AnimalsLot", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_lot", id_lot)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
    Public Function ERP_Prod_SP_Select_ProcessOutput(ByVal Id_Process As Long, ByVal Activo As Boolean) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_ProcessOutput", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Process", Id_Process)
                da.SelectCommand.Parameters.AddWithValue("@Activo", Activo)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

#End Region


#Region "Bodegas Vacias"
    Public Function ERP_Prod_SP_Select_StowageEmpty() As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_StowageEmpty", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
#End Region


#Region "Transferencia de animales"

    Public Function ERP_Prod_SP_Select_AnimalsLotMother(ByVal id_lot As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_AnimalsLotMother", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_lot", id_lot)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function ERP_Production_Get_StowageAvailableTransfer(ByVal ID_Production As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Production_Get_StowageAvailableTransfer", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Production", ID_Production)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function ERP_Production_Get_LotAvailableTransfer(ByVal ID_Production As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Production_Get_LotAvailableTransfer", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Production", ID_Production)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function ERP_Prod_SP_AnimalTransfersHeader(ByVal ID_Company_FK As Long, ByVal ID_Outlet_FK As Long, ByVal Commentary As String) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_AnimalTransfersHeader", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Outlet_FK", ID_Outlet_FK)
                da.SelectCommand.Parameters.AddWithValue("@Commentary", Commentary)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
    Public Function ERP_Prod_SP_AnimalTransfers(ByVal ID_Company_FK As Long, ByVal ID_Customer_FK As Long, ByVal ID_Stowage_FK As Long, ByVal ID_Product As Long, ByVal ID_TipoSalida As Long, ByVal IS_Mother As Integer, ByVal ID_Transfer_FK As Long, ByVal ID_Animal_FK As Long, ByVal id_AnimalWeights_FK As Long, ByVal LastWeight As Double, ByVal StowageOfDestination_FK As Long, ByVal LotOfDestination_FK As Long) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_AnimalTransfers", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product", ID_Product)
                da.SelectCommand.Parameters.AddWithValue("@ID_TipoSalida", ID_TipoSalida)
                da.SelectCommand.Parameters.AddWithValue("@IS_Mother", IS_Mother)
                da.SelectCommand.Parameters.AddWithValue("@ID_Transfer_FK", ID_Transfer_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Animal_FK", ID_Animal_FK)
                da.SelectCommand.Parameters.AddWithValue("@id_AnimalWeights_FK", id_AnimalWeights_FK)
                da.SelectCommand.Parameters.AddWithValue("@LastWeight", LastWeight)
                da.SelectCommand.Parameters.AddWithValue("@StowageOfDestination_FK", StowageOfDestination_FK)
                da.SelectCommand.Parameters.AddWithValue("@LotOfDestination_FK", LotOfDestination_FK)
                da.Fill(ds, "tabla")
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
#End Region

#Region "Animales por Bodega"
    Public Function ERP_Prod_SP_NumberOfAnimals(ByVal ID_Stowage As Long) As DataSet
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_NumberOfAnimals", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage", ID_Stowage)
                da.Fill(ds, "tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return ds
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return ds
        End Try
        Return ds
    End Function
#End Region

#Region "SubProductos"
    Public Function SP_ERP_InventoryGetSubProducts(ByVal Id_Product As Long, ByVal ID_Stowage_FK As Long) As DataTable
        Dim ds As New DataSet("datos")
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventoryGetSubProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Product", Id_Product)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.Fill(ds, "Products")
                dt = ds.Tables("Products")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_InventoryAddSubProducts(ByVal Id_Product As Long, ByVal NameProduct As String, ByVal Price_Sale As Double, ByVal ID_Stowage_FK As Long, ByVal ID_Company_FK As Long) As Integer
        Dim ds As New DataSet("datos")
        Dim resp As New Integer
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventoryAddSubProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Product", Id_Product)
                da.SelectCommand.Parameters.AddWithValue("@NameProduct", NameProduct)
                da.SelectCommand.Parameters.AddWithValue("@Price_Sale", Price_Sale)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company_FK", ID_Company_FK)
                da.Fill(ds, "Products")
                resp = ds.Tables("Products").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function


    Public Function SP_ERP_InventoryUpdateSubProducts(ByVal ID_SubProduct As Long, ByVal NameProduct As String, ByVal Price_Sale As Double) As Integer
        Dim ds As New DataSet("datos")
        Dim resp As New Integer
        Try
            Using da As New SqlDataAdapter("SP_ERP_InventoryUpdateSubProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_SubProduct", ID_SubProduct)
                da.SelectCommand.Parameters.AddWithValue("@NameProduct", NameProduct)
                da.SelectCommand.Parameters.AddWithValue("@Price_Sale", Price_Sale)
                da.Fill(ds, "Products")
                resp = ds.Tables("Products").Rows(0).Item("resp")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function
#End Region
#Region "Top Products"
    Public Function ERP_Inventory_GetProducts_StowageReport(ByVal Id_Company As Long, ByVal ID_Stowage_FK As Long) As DataSet
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_GetProducts_StowageReport", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage_FK", ID_Stowage_FK)
                da.Fill(ds, "Products")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un Error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return ds
    End Function

#End Region

#Region "Indicadores"
    Public Function ERP_Finance_Report_Payments() As DataSet
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Report_TotalToBeCharged", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return ds
    End Function

    Public Function ERP_Finance_Report_Totalexpiration() As DataSet
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Report_Totalexpiration", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return ds
    End Function
#End Region

#Region "Completar lotes de produccion"
    Public Function ERP_Production_UpdateProductionBatchCompletion(ByVal LastWeight As Double, ByVal id_AnimalWeights As Long, ByVal ID_Lot As Long) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Production_UpdateProductionBatchCompletion", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@LastWeight", LastWeight)
                da.SelectCommand.Parameters.AddWithValue("@id_AnimalWeights", id_AnimalWeights)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function
#End Region


    Public Function ERP_SP_Inventory_Report_Formulas(ByVal ID_Recipe As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_Report_Formulas", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Recipe", ID_Recipe)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

#Region "Barracos"

    Public Function ERP_Prod_SP_ADD_DaysOfExtraction(ByVal ID_Lot As Long, ByVal Day As String) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ADD_DaysOfExtraction", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.SelectCommand.Parameters.AddWithValue("@Day", Day)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function

    Public Function ERP_Prod_SP_DaysOfExtraction(ByVal ID_Lot As Long, ByVal Procesado As Integer) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_DaysOfExtraction", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.SelectCommand.Parameters.AddWithValue("@Procesado", Procesado)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function
#End Region

    Public Function ERP_Prod_SP_Select_Animal(ByVal ID_Group As Long, ByVal Tipo As Integer) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_Animal", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Group", ID_Group)
                da.SelectCommand.Parameters.AddWithValue("@Tipo", Tipo)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
    Public Function GetModelo(ByVal ID_Company As Integer, ID_Marca As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_SP_GetInventoryModelo", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", _ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                da.Fill(ds, "Modelo")
            End Using
            dt = ds.Tables("Modelo")
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

#Region "Unidad Conversion"
    Public Function ERP_Generic_GET_ConversionUnit(ByVal ID_Company As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Generic_GET_ConversionUnit", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function ERP_Generic_GetConversionUnitProducts(ByVal ID_Product As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Generic_GetConversionUnitProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Product", ID_Product)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function
#End Region


#Region "Compras"
    Public Function ERP_SP_Inventory_SuggestedShopping(ByVal ID_Stowage As Long, ByVal Tipo As Integer, ByVal ID_Customer As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_SuggestedShopping", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Stowage", ID_Stowage)
                da.SelectCommand.Parameters.AddWithValue("@Tipo", Tipo)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
            End Using
        Catch ex As SqlException
            MessageBox.Show(MSGERROR, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return resp
        End Try
        Return resp
    End Function

    Public Function ERP_SP_Inventory_GenerateOrder(ByVal ID_Customer As Long) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GenerateOrder", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function

    Public Function ERP_SP_Inventory_GenerateOrderDetails(ByVal ID_OrdersHeader As Long, ByVal ID_Product As Long, ByVal Quantity As Double) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_GenerateOrderDetails", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_OrdersHeader", ID_OrdersHeader)
                da.SelectCommand.Parameters.AddWithValue("@ID_Product", ID_Product)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function


#End Region
#Region "Detalles de Orden de Compras"
    Public Function ERP_SP_Report_Inventory_GenerateOrderDetails(ByVal ID_OrdersHeader As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_SP_Report_Inventory_GenerateOrderDetails", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_OrdersHeader", ID_OrdersHeader)
                da.Fill(ds, "info")
                dt = ds.Tables("info")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function
#End Region

#Region "Provider's List Report"
    Public Function ERP_Generic_GetCustomerMaster_ProviderReport() As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_Generic_GetCustomerMaster_ProviderReport", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Data_Id_Company)
                da.Fill(ds, "info")
                dt = ds.Tables("info")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function
#End Region

#Region "Sacrificio de animales"

    Public Function ERP_Production_UpdateSacrificeAnimals(ByVal LastWeight As Double, ByVal id_AnimalWeights As Long, ByVal ID_Lot As Long) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Production_UpdateSacrificeAnimals", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@LastWeight", LastWeight)
                da.SelectCommand.Parameters.AddWithValue("@id_AnimalWeights", id_AnimalWeights)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function
#End Region


    Public Function SP_ERP_Inventory_Kardex(ByVal ID_Company As Long, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdProducto As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Kardex", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal)
                da.SelectCommand.Parameters.AddWithValue("@IdProducto", IdProducto)

                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_SugeridoCompras(ByVal ID_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_SugeridoCompras", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function
    Public Function SP_ERP_Inventory_SaldoExistencias(ByVal ID_Company As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_SaldoExistencias", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function
    Public Function SP_ERP_Inventory_Ingreso_Productos(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdProveedor As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Ingreso_Productos", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaIncial", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFinal", fechaFinal)
                da.SelectCommand.Parameters.AddWithValue("@IdProveedor", IdProveedor)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_SaldoCuentas(ByVal ID_Company As Long, ByVal Fecha As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_SaldoCuentas", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_BienesConsumosEntrgadosUnidadesOrganizativas(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdCategory As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_BienesConsumosEntrgadosUnidadesOrganizativas", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal)
                da.SelectCommand.Parameters.AddWithValue("@IdCategory", IdCategory)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_EntregaProductosDepartamento(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdDepartment As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_EntregaProductosDepartamento", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFinal", fechaFinal)
                da.SelectCommand.Parameters.AddWithValue("@IdDepartment", IdDepartment)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ControlInventario(ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_ControlInventario", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaInicial", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFina", fechaFinal)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function SP_ERP_Inventory_Balance_Mensual_Almacen(ByVal Id_Category As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Balance_Mensual_Almacen", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Category", Id_Category)
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_Ficha_Resumida_Activo(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, Byval OrdenadoPor As String ) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Dim obj As New Generic_SQLServer
            Using cmd As SqlCommand = obj.AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                             Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                             UnidadOrganizativa, Id_Employee, fechaInicial,
                                             fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                             FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                             FechasAct, FechaAd, ValorAd, OrdenadoPor, "SP_ERP_Inventory_Ficha_Resumida_Activo", New SqlClient.SqlConnection(connStr))
                Using da As New SqlDataAdapter(cmd)

                    da.Fill(ds, "EntryReport")
                    dt = ds.Tables("EntryReport")
                End Using
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ReportePeriodicoBajas(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Dim obj As New Generic_SQLServer
            Using cmd As SqlCommand = obj.AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                 Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                 UnidadOrganizativa, Id_Employee, fechaInicial,
                                                 fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                 FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                 FechasAct, FechaAd, ValorAd, "", "SP_ERP_Inventory_ReportePeriodicoBajas", New SqlClient.SqlConnection(connStr))
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(ds, "EntryReport")
                    dt = ds.Tables("EntryReport")
                End Using
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ReportePeriodicoAltas(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Dim obj As New Generic_SQLServer
            Using cmd As SqlCommand = obj.AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                     Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                     UnidadOrganizativa, Id_Employee, fechaInicial,
                                                     fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                     FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                     FechasAct, FechaAd, ValorAd, "", "SP_ERP_Inventory_ReportePeriodicoAltas", New SqlClient.SqlConnection(connStr))
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(ds, "EntryReport")
                    dt = ds.Tables("EntryReport")
                End Using
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_RegistroContableAltasBaja(ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_RegistroContableAltasBaja", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal)

                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijo(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdActivo As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijo", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicial.ToString("yyyy-MM-dd"))
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal.ToString("yyyy-MM-dd"))
                da.SelectCommand.Parameters.AddWithValue("@ID_FixedAssets", IdActivo)

                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ReporteAmortizacion(ByVal Id_Company As Integer, ByVal Id_HeaderAmortization As Integer) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("Amortizacion")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_ReporteAmortizacion", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_HeaderAmortization", Id_HeaderAmortization)

                da.Fill(ds, "Amortizacion")
                dt = ds.Tables("Amortizacion")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ReporteTransparencia(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try

            Dim obj As New Generic_SQLServer
            Using cmd As SqlCommand = obj.AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                             Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                             UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                             FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                             FechasAct, FechaAd, ValorAd, OrdenadoPor, "SP_ERP_Inventory_ReporteTransparencia", New SqlClient.SqlConnection(connStr))
                Using da As New SqlDataAdapter(cmd)

                    da.Fill(ds, "EntryReport")
                    dt = ds.Tables("EntryReport")
                End Using
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijoContable(ByVal Id_Company As Integer, ByVal Codigo As String,
                                                                                    ByVal fechaInicial As Date, ByVal fechaFinal As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijoContable", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal)
                da.SelectCommand.Parameters.AddWithValue("@Codigo", Codigo)

                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_Reporte_Salida_Producto(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdProducto As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Reporte_Salida_Producto", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal)
                da.SelectCommand.Parameters.AddWithValue("@IdProducto", IdProducto)

                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function


    Public Function SP_ERP_Inventory_Entradas_Por_Producto(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal IdProducto As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_Entradas_Por_Producto", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                da.SelectCommand.Parameters.AddWithValue("@IdProducto", IdProducto)
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicial)
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFinal)

                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function

    Public Function SP_ERP_Inventory_AniosBalance() As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Using da As New SqlDataAdapter("SP_ERP_Inventory_AniosBalance", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds, "EntryReport")
                dt = ds.Tables("EntryReport")
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function



    Public Function SP_ERP_inventory_Cuadro_Depreciacion(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Dim obj As New Generic_SQLServer
            Using cmd As SqlCommand = obj.AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                 Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                 UnidadOrganizativa, Id_Employee, fechaInicial,
                                                 fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                 FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                 FechasAct, FechaAd, ValorAd, OrdenadoPor, "SP_ERP_inventory_Cuadro_Depreciacion", New SqlClient.SqlConnection(connStr))
                Using da As New SqlDataAdapter(cmd)



                    da.Fill(ds, "EntryReport")
                    dt = ds.Tables("EntryReport")
                End Using
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function
    Public Function SP_ERP_Inventory_Detalle_General_Bienes(ByVal Id_Company As Integer, ByVal Codigo As String, ByVal NombreActivo As String, ByVal Id_FixedAssetsType As String,
                                                         ByVal Id_FixedAssetsTypeSub As String, ByVal UbicacionPrimaria As String, ByVal UbicacionSecundaria As String,
                                                         ByVal UnidadOrganizativa As String, ByVal Id_Employee As Integer, ByVal fechaInicial As Date,
                                                         ByVal fechaFinal As Date, ByVal Id_estado_Fk As Integer, ByVal FechaAdquisicionInicial As Date,
                                                         ByVal FechaAdquisicionFinal As Date, ByVal RangoValorAdquisicionInicial As Decimal, ByVal RangoValorAdquisicionFinal As Decimal,
                                                         ByVal FechasAct As Boolean, ByVal FechaAd As Boolean, ByVal ValorAd As Boolean, ByVal OrdenadoPor As String) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("EntryReport")
        Try
            Dim obj As New Generic_SQLServer
            Using cmd As SqlCommand = obj.AgregarValores(Id_Company, Codigo, NombreActivo, Id_FixedAssetsType,
                                                     Id_FixedAssetsTypeSub, UbicacionPrimaria, UbicacionSecundaria,
                                                     UnidadOrganizativa, Id_Employee, fechaInicial,
                                                     fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                     FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal,
                                                     FechasAct, FechaAd, ValorAd, OrdenadoPor, "SP_ERP_Inventory_Detalle_General_Bienes", New SqlClient.SqlConnection(connStr))
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(ds, "EntryReport")
                    dt = ds.Tables("EntryReport")
                End Using
            End Using
        Catch ex As SqlException
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        Catch ex As Exception
            SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
        End Try
        Return dt
    End Function




    Public Function ERP_Inventory_DeleteIngredientsRecipe(ByVal ID_Ingredients As Long) As Long
        Dim resp As Long = 0
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_Inventory_DeleteIngredientsRecipe", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Ingredients", ID_Ingredients)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
		Return resp
	End Function
	Public Sub Dispose() Implements IDisposable.Dispose

    End Sub
End Class
