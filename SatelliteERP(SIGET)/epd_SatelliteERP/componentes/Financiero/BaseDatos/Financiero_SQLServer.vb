Imports System.Data.SqlClient

Public Class Financiero_SQLServer : Implements IDisposable

    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()
    Friend Function DataCenter() As String
        Return SQLConfiguration.EpdConnectionString.ToString
        REM  Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function
    Public Function GetAccountingCatalog(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finansas_GetAccountingCatalog", conn)
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
    Public Function InsertAccountingCatalog(ByVal id_Company As Long, ByVal Id_TypeAccount_FK As Long, ByVal IsDetail As Integer,
                                    ByVal NoCuentaContable As String, ByVal CuentaContable As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_InsertAccountingCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_TypeAcount", SqlDbType.BigInt).Value = Id_TypeAccount_FK
                cmd.Parameters.Add("@IsDetail", SqlDbType.Bit).Value = IsDetail
                cmd.Parameters.Add("@NoCuentaContable", SqlDbType.VarChar).Value = NoCuentaContable
                cmd.Parameters.Add("@CuentaContable", SqlDbType.VarChar).Value = CuentaContable
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuníquese con Soporte Técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Public Function SetAccountingCatalog(ByVal Id_Account As Long, ByVal id_Company As Long,
                                    ByVal Id_TypeAccount_FK As Long, ByVal IsDetail As Integer,
                                    ByVal NoCuentaContable As String, ByVal CuentaContable As String,
                                         ByVal Id_CashFlow As Long) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SetAccountingCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Account", SqlDbType.BigInt).Value = Id_Account
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_TypeAcount", SqlDbType.VarChar).Value = Id_TypeAccount_FK
                cmd.Parameters.Add("@IsDetail", SqlDbType.Bit).Value = IsDetail
                cmd.Parameters.Add("@NoCuentaContable", SqlDbType.VarChar).Value = NoCuentaContable
                cmd.Parameters.Add("@CuentaContable", SqlDbType.VarChar).Value = CuentaContable
                cmd.Parameters.Add("@ID_CashFlow", SqlDbType.BigInt).Value = Id_CashFlow
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables("datos").Rows(0).Item(0)
                            Return resp
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuníquese con Soporte Técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Function DelAccountingCatalog(ByVal Id_Account As Long, ByVal id_Company As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_DelAccountingCatalog", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Account", SqlDbType.BigInt).Value = Id_Account
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuníquese con Soporte Técnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrió un error al cargar la información.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetAccountingItem(ByVal id_Company As Long, ByVal Id_Entry As Long, ByVal Id_Movimiento_FK As Long,
                                      ByVal Id_CentroCosto_FK As Long, ByVal Id_CuentaContable_FK As Long, ByVal NoCuentaCotable As String,
                                      ByVal Cargo As Decimal, ByVal abono As Decimal, ByVal BusinessDay As Date) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Accounting_Item_Add", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Entry", SqlDbType.BigInt).Value = Id_Entry
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Movimiento_FK", SqlDbType.BigInt).Value = Id_Movimiento_FK
                cmd.Parameters.Add("@Id_MonedaMovimiento_FK", SqlDbType.BigInt).Value = Id_Movimiento_FK
                cmd.Parameters.Add("@Id_CentroCosto_FK", SqlDbType.BigInt).Value = Id_CentroCosto_FK
                cmd.Parameters.Add("@Id_CuentaContable_FK", SqlDbType.BigInt).Value = Id_CuentaContable_FK
                cmd.Parameters.Add("@NoCuentaCotable", SqlDbType.VarChar).Value = NoCuentaCotable
                cmd.Parameters.Add("@Cargo", SqlDbType.Money).Value = Cargo
                cmd.Parameters.Add("@Abono", SqlDbType.Money).Value = abono
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#Region "Partidas Contables"
    Public Function GetClassificationItemType(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_GetClassificationItemType", conn)
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
    Public Function SetAccountingIitemHeading(ByVal id_Company As Long, ByVal Id_ClassificationItemType As Long, ByVal BusinessDay As Date, ByVal Concept_AccountingIitemHeading As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingIitemHeading_Insert", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_ClassificationItemType_FK", SqlDbType.BigInt).Value = Id_ClassificationItemType
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.Parameters.Add("@Concept_AccountingIitemHeading", SqlDbType.VarChar).Value = Concept_AccountingIitemHeading
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK|" & ds.Tables("datos").Rows(0)("ID")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al ingresar el encabezado de la partida contable."
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetAccountingIitemBody(ByVal Id_AccountingIitemHeading_FK As Long, ByVal Id_Account As Long, ByVal NumberAccount As String, ByVal Concept_AccountingIitemBody As String, ByVal Item_Charge As Decimal, ByVal Iteml_Deposit As Decimal,
                                          ByVal Is_Deductible As Boolean, ByVal ID_CostCenter As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingIitemBody_Insert", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_AccountingIitemHeading_FK", SqlDbType.BigInt).Value = Id_AccountingIitemHeading_FK
                cmd.Parameters.Add("@Id_Account_FK", SqlDbType.BigInt).Value = Id_Account
                cmd.Parameters.Add("@NumberAccount", SqlDbType.VarChar).Value = NumberAccount
                cmd.Parameters.Add("@Concept_AccountingIitemBody", SqlDbType.VarChar).Value = Concept_AccountingIitemBody
                cmd.Parameters.Add("@Item_Charge", SqlDbType.Money).Value = Item_Charge
                cmd.Parameters.Add("@Iteml_Deposit", SqlDbType.Money).Value = Iteml_Deposit
                cmd.Parameters.Add("@Is_Deductible", SqlDbType.Bit).Value = Is_Deductible
                cmd.Parameters.Add("@ID_CostCenter_FK", SqlDbType.BigInt).Value = ID_CostCenter
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK|" & ds.Tables("datos").Rows(0)("ID")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al ingresar el encabezado de la partida contable."
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetAccountingIitemHeading(ByVal id_Company As Long, ByVal BusinessDay As Date, Optional ByVal Is_Posting As Boolean = False) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingIitemHeading_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.Parameters.Add("@Is_Posting", SqlDbType.Bit).Value = Is_Posting
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
    Public Function GetFinance_AccountingIitemBody(ByVal id_Company As Long, ByVal Id_AccountingIitemHeading As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingIitemBody_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_AccountingIitemHeading", SqlDbType.BigInt).Value = Id_AccountingIitemHeading
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
    Public Function GeFinance_AccountingIitemValidate(ByVal id_Company As Long, ByVal Id_AccountingIitemHeading As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingIitem_Validate", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_AccountingIitemHeading", SqlDbType.BigInt).Value = Id_AccountingIitemHeading
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
    Public Function GeFinance_AccountingItem_Select(ByVal id_Company As Long, ByVal Id_AccountingItemHeading As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingItem_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_AccountingItemHeading", SqlDbType.BigInt).Value = Id_AccountingItemHeading
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
    Public Function SetFinance_AccountingItem_Posting(ByVal id_Company As Long, ByVal Id_AccountingItemHeading As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountingIitem_Posting", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_AccountingItemHeading", SqlDbType.BigInt).Value = Id_AccountingItemHeading
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0)(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|No existe respuesta de base de datos"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "Activo Fijo"
    Public Function GetFinance_FixedAssetsMaster_SelectALL(ByVal id_Company As Long, ByVal Id_Deparment_FK As Integer, ByVal FechaProceso As Date) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_SelectAllActives", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Deparment_FK
                cmd.Parameters.Add("@FechaProceso", SqlDbType.Date).Value = FechaProceso

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

    Public Function GetFinance_FixedAssetsMaster_Select(ByVal id_Company As Long, ByVal Id_Deparment_FK As Integer, Optional id_employee As Long = 0, Optional TipoActivos As Integer = 0) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = Id_Deparment_FK
                cmd.Parameters.Add("@Id_Employee", SqlDbType.BigInt).Value = id_employee
                cmd.Parameters.Add("@TipoActivos", SqlDbType.Int).Value = TipoActivos

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


    Public Function GetFinance_FixedAssetsMaster_Descargados(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_Descargado", conn)
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

    Public Function GetFinance_FixedAssetsMaster_SelectIdividual(ByVal id_Company As Long, ByVal Id_FixedAsset As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_SelectIndivid", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@IdFixedAssets", SqlDbType.BigInt).Value = Id_FixedAsset

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "Encabezado")
                            Return ds.Tables("Encabezado")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("Encabezado")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function GetFinance_FixedAssetsMaster_Select(ByVal id_Company As Long, ByVal busqueda As String,
                                                        ByVal Id_Deparment_FK As Integer, ByVal ProcessTrans As Integer,
                                                        Optional id_employee As Long = 0) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_Select_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
                cmd.Parameters.Add("@Id_Department_FK", SqlDbType.Int).Value = Id_Deparment_FK
                cmd.Parameters.Add("@ProcessTrans", SqlDbType.Int).Value = ProcessTrans
                cmd.Parameters.Add("@Id_Employee", SqlDbType.Int).Value = id_employee

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


    Public Function GetAmortizacion_FixedAssetsMaster_Select(ByVal id_Company As Long, ByVal busqueda As String,
                                                        ByVal Id_Deparment_FK As Integer, ByVal ProcessTrans As Integer,
                                                        Optional id_employee As Long = 0) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Amortizacion_Master_Select_LIKE", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@busqueda", SqlDbType.VarChar).Value = busqueda
                cmd.Parameters.Add("@Id_Department_FK", SqlDbType.Int).Value = Id_Deparment_FK
                cmd.Parameters.Add("@ProcessTrans", SqlDbType.Int).Value = ProcessTrans
                cmd.Parameters.Add("@Id_Employee", SqlDbType.Int).Value = id_employee

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

    Public Function ERP_FixedAssets_Masterimage_Select(ByVal ID_FixedAssets_FK As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Masterimage_Select", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_FixedAssets_FK", SqlDbType.BigInt).Value = ID_FixedAssets_FK
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


    Public Function SP_ERP_ConfigAmountCapitalizable() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("SP_ERP_ConfigAmountCapitalizable", conn)
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




    Public Function ERP_FixedAssets_Masterimage_Delete(ByVal ID_MasterImage As Long, ByVal ID_FixedAssets_FK As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_FixedAssets_Masterimage_Delete]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@ID_MasterImage", SqlDbType.BigInt).Value = ID_MasterImage
                cmd.Parameters.Add("@ID_FixedAssets_FK", SqlDbType.BigInt).Value = ID_FixedAssets_FK
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

    Public Function GetFixedAssetsType(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetType", conn)
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

    Public Function ERP_getFixedAssets_State() As DataTable
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

    Public Function GetFixedAssetsType_Sub(ByVal id_Company As Long, FixedAssetsType As Int64) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetType_Sub", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@FixedAssetsType", SqlDbType.BigInt).Value = FixedAssetsType
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
    Public Function SetFixedAssets_Master_Insert(ByVal Id_Company As Long, ByVal ID_Provider As Long, ByVal Id_TypeCustomerCustomer As Long, ByVal Id_Depreciation As Long,
                                                 ByVal Id_Location As Long, ByVal Id_ResponsiblePerson As Long, ByVal Name_FiexdAssets As String, ByVal Description As String,
                                                 ByVal Number_Purchase As String, ByVal Date_Acquisition As Date, ByVal ResidualValue As Decimal, ByVal Amount_Acquired As Decimal,
                                                 ID_FixedAssets_Sub As Int64, Id_FixedAssetsType As Int64, ID_Marca As Integer, ID_Modelo As Integer,
                                                 Numero_serie As String, ByVal ID_Legacy As String, ByVal Observations As String,
                                                 ByRef id_estado_FK As Integer, ByVal color As String, ByVal material As String, ByVal Invoice_numbers As String, ByVal Capitalizable As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_Master_Insert", conn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@Id_Company_FK", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_Provider_FK", SqlDbType.BigInt).Value = ID_Provider
                cmd.Parameters.Add("@Id_TypeCustomerCustomer_FK", SqlDbType.BigInt).Value = Id_TypeCustomerCustomer
                cmd.Parameters.Add("@Id_Depreciation_FK", SqlDbType.BigInt).Value = Id_Depreciation
                cmd.Parameters.Add("@Id_Location_FK", SqlDbType.BigInt).Value = Id_Location
                cmd.Parameters.Add("@Id_ResponsiblePerson_FK", SqlDbType.BigInt).Value = Id_ResponsiblePerson
                cmd.Parameters.Add("@Name_FiexdAssets", SqlDbType.VarChar).Value = Name_FiexdAssets
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@Number_Purchase", SqlDbType.VarChar).Value = Number_Purchase
                cmd.Parameters.Add("@Date_Acquisition", SqlDbType.Date).Value = Date_Acquisition
                cmd.Parameters.Add("@ResidualValue", SqlDbType.Money).Value = ResidualValue
                cmd.Parameters.Add("@Amount_Acquired", SqlDbType.Money).Value = Amount_Acquired
                cmd.Parameters.Add("@ID_FixedAssets_Sub", SqlDbType.BigInt).Value = ID_FixedAssets_Sub
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@id_Marca", SqlDbType.BigInt).Value = ID_Marca
                cmd.Parameters.Add("@Id_Modelo", SqlDbType.BigInt).Value = ID_Modelo
                cmd.Parameters.Add("@Number_Serie", SqlDbType.VarChar).Value = Numero_serie
                cmd.Parameters.Add("@ID_Legacy", SqlDbType.VarChar).Value = ID_Legacy
                cmd.Parameters.Add("@Observations", SqlDbType.VarChar).Value = Observations
                cmd.Parameters.Add("@id_estado_FK", SqlDbType.BigInt).Value = id_estado_FK
                cmd.Parameters.Add("@Capitalizable", SqlDbType.Bit).Value = Capitalizable

                cmd.Parameters.Add("@color", SqlDbType.VarChar).Value = color
                cmd.Parameters.Add("@material", SqlDbType.VarChar).Value = material
                cmd.Parameters.Add("@Invoice_numbers", SqlDbType.VarChar).Value = Invoice_numbers


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK|" & ds.Tables("datos").Rows(0)("ID")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al ingresar el encabezado de la partida contable."
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_FixedAssets_MasterImage_Insert(ByVal ID_FixedAssets_FK As Long, ByVal Image As Byte())
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_MasterImage_Insert", conn)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@ID_FixedAssets_FK", SqlDbType.BigInt).Value = ID_FixedAssets_FK
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = Image
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As Exception

                            Return "ER|Error al ingresar la imagen."
                        End Try
                    End Using
                End Using
            End Using
        End Using

    End Function
#End Region
#Region "Sub Tipo de Activo"
    Public Function GetFixedAssetsSubType(ByVal id_Company As Long, ByVal Optional FixedAssetsType As Long = 0) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_GetType_sub_All", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@FixedAssetsType", SqlDbType.BigInt).Value = FixedAssetsType
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
    Public Function CreateFixedAssetsSubTypes(ByVal id_Company As Long, ByVal Id_FixedAssetsType As Long, ByVal Id_FixedAssetsSubTypeName As String, ByVal Id_FixedAssetsSubTypeDescription As String, ByVal is_tangible As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_InsertType_sub", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@Id_FixedAssetsSubTypeName", SqlDbType.VarChar).Value = Id_FixedAssetsSubTypeName
                cmd.Parameters.Add("@Id_FixedAssetsSubTypeDescription", SqlDbType.VarChar).Value = Id_FixedAssetsSubTypeDescription
                cmd.Parameters.Add("@is_tangible", SqlDbType.Bit).Value = is_tangible

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

    Public Function ModifyFixedAssetsSubTypes(ByVal id_Company As Long, ByVal Id_FixedAssetsSubType As Long, ByVal Id_FixedAssetsType As Long, ByVal Id_FixedAssetsSubTypeName As String, ByVal Id_FixedAssetsSubTypeDescription As String, ByVal is_tangible As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_ModifyType_sub", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_FixedAssetsType", SqlDbType.BigInt).Value = Id_FixedAssetsType
                cmd.Parameters.Add("@Id_FixedAssetsSubType", SqlDbType.BigInt).Value = Id_FixedAssetsSubType
                cmd.Parameters.Add("@Id_FixedAssetsSubTypeName", SqlDbType.VarChar).Value = Id_FixedAssetsSubTypeName
                cmd.Parameters.Add("@Id_FixedAssetsSubTypeDescription", SqlDbType.VarChar).Value = Id_FixedAssetsSubTypeDescription
                cmd.Parameters.Add("@is_tangible", SqlDbType.Bit).Value = is_tangible

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

    Public Function DeleteFixedAssetsSubTypes(ByVal id_Company As Long, ByVal Id_FixedAssetsType_Sub As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Dim resp As String = ""
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_DeleteType_sub", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@Id_FixedAssetsType_Sub", SqlDbType.BigInt).Value = Id_FixedAssetsType_Sub
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
#Region "Mantenimiento Type Acount"
    Public Function GetTypeAcount(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_GetTypeAcount", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.CommandType = CommandType.StoredProcedure
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

    Public Function InsertTypeAcount(ByVal id_Company As Long, ByVal NameTypeAcount As String,
                                    ByVal Signo As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_InsertTypeAcount", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@NameTypeAcount", SqlDbType.VarChar).Value = NameTypeAcount
                cmd.Parameters.Add("@Signo", SqlDbType.Char).Value = Signo
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

    Public Function SetTypeAcount(ByVal Id_TypeAcount As Long, ByVal id_Company As Long,
                                    ByVal NameTypeAcount As String, ByVal Signo As String) As String
        Dim resp As Integer = 0
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SetTypeAcount", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_TypeAcount", SqlDbType.BigInt).Value = Id_TypeAcount
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
                cmd.Parameters.Add("@NameTypeAcount", SqlDbType.VarChar).Value = NameTypeAcount
                cmd.Parameters.Add("@Signo", SqlDbType.Char).Value = Signo
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            resp = ds.Tables(0).Rows(0).Item(0)
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

    Public Function DelTypeAcount(ByVal Id_TypeAcount As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_DelTypeAcount", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_TypeAcount", SqlDbType.BigInt).Value = Id_TypeAcount
                'cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
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
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ERROR"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "CashFlow"

    Public Function GetCashFlow_Select(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_CashFlow_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.CommandType = CommandType.StoredProcedure
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
#End Region
#Region "Config Billing"

    Public Function GetConfigBilling_Select(ByVal Id_Company As Long, ByVal ID_Type_Billing As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountsReceivable_ConfigBilling_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_Type_Billing", SqlDbType.BigInt).Value = ID_Type_Billing
                cmd.CommandType = CommandType.StoredProcedure
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
    Public Function SetConfigBilling(ByVal ID_Billing As Long, ByVal Id_Company As Long, ByVal ID_Type_Billing As Long, ByVal Name_Billing As String, Config_XML As String,
                                     ByVal Schema_XML As String, ByVal picture As Byte(), ByVal Is_Active As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_AccountsReceivable_ConfigBilling_Update", conn)
                cmd.Parameters.Add("@ID_Billing", SqlDbType.BigInt).Value = ID_Billing
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_Type_Billing", SqlDbType.BigInt).Value = ID_Type_Billing
                cmd.Parameters.Add("@Name_Billing", SqlDbType.VarChar).Value = Name_Billing
                cmd.Parameters.Add("@Config_XML", SqlDbType.Xml).Value = Config_XML
                cmd.Parameters.Add("@Schema_XML", SqlDbType.Xml).Value = Schema_XML
                cmd.Parameters.Add("@picture", SqlDbType.Image).Value = picture
                cmd.Parameters.Add("@Is_Active", SqlDbType.Bit).Value = Is_Active
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "Invoice"
    Public Function GetInvoice_TransactionHeader_Select(ByVal Id_Company As Long, ByVal BusinessDay As Date) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_SP_Invoice_Transaction_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.CommandType = CommandType.StoredProcedure
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
    Public Function GetInvoice_TransactionDetail_Select(ByVal Id_Company As Long, ByVal ID_TransactionHeader As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_SP_Invoice_TransactionDetail_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_TransactionHeader", SqlDbType.BigInt).Value = ID_TransactionHeader
                cmd.CommandType = CommandType.StoredProcedure
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
    Public Function SetInvoice_TransactionHeader(ByVal StatusTransaction As Boolean, ByVal Id_Company As Long,
                                                 ByVal ReasonRefund As String, ByVal ID_PaymentType As Long, ByVal ID_Discount As Long,
                                                 ByVal DiscountPercent As Decimal, ByVal ID_Customer As Long, Fullpayment As Decimal,
                                                 ByVal IVA_Paid As Decimal, ByVal Fovial_Cotrans As Decimal, ByVal DocumentNumber As Long, ByVal PurchaseType As String,
                                                 ByVal BankAccount As String, ByVal Id_BankCatalog_FK As Long, ByVal CheckNumber As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_TransactionHeader", conn)

                cmd.Parameters.Add("@StatusTransaction", SqlDbType.Bit).Value = StatusTransaction
                cmd.Parameters.Add("@ID_Company_FK", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ReasonRefund", SqlDbType.VarChar).Value = ReasonRefund
                cmd.Parameters.Add("@ID_PaymentType_FK", SqlDbType.BigInt).Value = ID_PaymentType
                cmd.Parameters.Add("@ID_Discount_FK", SqlDbType.BigInt).Value = ID_Discount
                cmd.Parameters.Add("@DiscountPercent", SqlDbType.Money).Value = DiscountPercent
                cmd.Parameters.Add("@ID_Customer_FK", SqlDbType.BigInt).Value = ID_Customer
                cmd.Parameters.Add("@Fullpayment", SqlDbType.Money).Value = Fullpayment
                cmd.Parameters.Add("@IVA_Paid", SqlDbType.Money).Value = IVA_Paid
                cmd.Parameters.Add("@Fovial_Cotrans", SqlDbType.Money).Value = Fovial_Cotrans
                cmd.Parameters.Add("@DocumentNumber", SqlDbType.BigInt).Value = DocumentNumber
                cmd.Parameters.Add("@PurchaseType", SqlDbType.VarChar).Value = PurchaseType

                cmd.Parameters.Add("@BankAccount", SqlDbType.VarChar).Value = BankAccount
                cmd.Parameters.Add("@Id_BankCatalog_FK", SqlDbType.BigInt).Value = Id_BankCatalog_FK
                cmd.Parameters.Add("@CheckNumber", SqlDbType.VarChar).Value = CheckNumber

                REM cmd.Parameters.Add("@DocumentNumber", SqlDbType.BigInt).Value = DocumentNumber
                cmd.CommandType = CommandType.StoredProcedure
                Using da1 As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da1.Fill(ds, "datos")
                            Return "OK|" & CType(ds.Tables("datos").Rows(0).Item(0), Long).ToString("0000000000")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetInvoice_TransactionVoid(ByVal ID_TransactionHeader As Long, ByVal ID_Company As Long, ByVal ObservationCancellation As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_TransactionHeaderVoid", conn)
                cmd.Parameters.Add("@ID_TransactionHeader", SqlDbType.BigInt).Value = ID_TransactionHeader
                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@ObservationCancellation", SqlDbType.VarChar).Value = ObservationCancellation

                cmd.CommandType = CommandType.StoredProcedure
                Using da1 As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da1.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SetInvoice_TransactionDetail(ByVal ID_TransactionHeader As Long, ByVal ID_Company As Long, ByVal ID_Product As Long,
           ByVal Description As String, ByVal Quantity As Decimal, ByVal PriceWithIVA As Decimal, ByVal PriceWithoutIva As Decimal, ByVal Discount As Decimal,
           ByVal TotalAmount As Decimal, ByVal Exempt As Boolean, ByVal BusinessDay As Date, ByVal COTRANS As Decimal, ByVal FOVIAL As Decimal,
           ByVal EndTransaction As Boolean, ByVal ID_Output As Long, ByVal ID_Stowage As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_TransactionDetail", conn)
                cmd.Parameters.Add("@ID_TransactionHeader_FK", SqlDbType.BigInt).Value = ID_TransactionHeader
                cmd.Parameters.Add("@ID_Company_FK", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@ID_Product_FK", SqlDbType.BigInt).Value = ID_Product
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@Quantity", SqlDbType.Money).Value = Quantity

                cmd.Parameters.Add("@PriceWithIVA", SqlDbType.Money).Value = PriceWithIVA
                cmd.Parameters.Add("@PriceWithoutIva", SqlDbType.Money).Value = PriceWithoutIva
                cmd.Parameters.Add("@Discount", SqlDbType.Money).Value = Discount
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Money).Value = TotalAmount
                cmd.Parameters.Add("@Exempt", SqlDbType.Money).Value = Exempt
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.Parameters.Add("@COTRANS", SqlDbType.Money).Value = COTRANS
                cmd.Parameters.Add("@FOVIAL", SqlDbType.Money).Value = FOVIAL
                cmd.Parameters.Add("@EndTransaction", SqlDbType.Bit).Value = EndTransaction
                cmd.Parameters.Add("@ID_Output_FK", SqlDbType.BigInt).Value = ID_Output
                cmd.Parameters.Add("@ID_Stowage_FK", SqlDbType.BigInt).Value = ID_Stowage

                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK|" & CType(ds.Tables("datos").Rows(0).Item(0), Long).ToString("0000000000")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetQuotation_TransactionHeader_Select(ByVal Id_Company As Long, ByVal BusinessDay As Date) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_SP_Invoice_Quotation_Transaction_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.CommandType = CommandType.StoredProcedure
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
    Public Function SetQuotation_TransactionHeader(ByVal StatusTransaction As Boolean, ByVal Id_Company As Long,
                                                 ByVal ReasonRefund As String, ByVal ID_PaymentType As Long, ByVal ID_Discount As Long,
                                                 ByVal DiscountPercent As Decimal, ByVal ID_Customer As Long, Fullpayment As Decimal,
                                                 ByVal IVA_Paid As Decimal, ByVal Fovial_Cotrans As Decimal, ByVal DocumentNumber As Long, ByVal TypeDocument As Long, ByVal PurchaseType As String) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_Quotation_TransactionHeader", conn)

                cmd.Parameters.Add("@StatusTransaction", SqlDbType.Bit).Value = StatusTransaction
                cmd.Parameters.Add("@ID_Company_FK", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ReasonRefund", SqlDbType.VarChar).Value = ReasonRefund
                cmd.Parameters.Add("@ID_PaymentType_FK", SqlDbType.BigInt).Value = ID_PaymentType
                cmd.Parameters.Add("@ID_Discount_FK", SqlDbType.BigInt).Value = ID_Discount
                cmd.Parameters.Add("@DiscountPercent", SqlDbType.Money).Value = DiscountPercent
                cmd.Parameters.Add("@ID_Customer_FK", SqlDbType.BigInt).Value = ID_Customer
                cmd.Parameters.Add("@Fullpayment", SqlDbType.Money).Value = Fullpayment
                cmd.Parameters.Add("@IVA_Paid", SqlDbType.Money).Value = IVA_Paid
                cmd.Parameters.Add("@Fovial_Cotrans", SqlDbType.Money).Value = Fovial_Cotrans
                cmd.Parameters.Add("@DocumentNumber", SqlDbType.BigInt).Value = DocumentNumber
                cmd.Parameters.Add("@TypeDocument", SqlDbType.BigInt).Value = TypeDocument
                cmd.Parameters.Add("@PurchaseType", SqlDbType.VarChar).Value = PurchaseType


                REM cmd.Parameters.Add("@DocumentNumber", SqlDbType.BigInt).Value = DocumentNumber
                cmd.CommandType = CommandType.StoredProcedure
                Using da1 As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da1.Fill(ds, "datos")
                            Return "OK|" & CType(ds.Tables("datos").Rows(0).Item(0), Long).ToString("0000000000")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function SetQuotation_TransactionVoid(ByVal ID_TransactionHeader As Long, ByVal ID_Company As Long, ByVal ObservationCancellation As String, ByVal ID_TransactionHeader_Invoice As Long) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_Quotation_TransactionHeaderVoid", conn)
                cmd.Parameters.Add("@ID_TransactionHeaderQuotation", SqlDbType.BigInt).Value = ID_TransactionHeader
                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@ObservationCancellation", SqlDbType.VarChar).Value = ObservationCancellation
                cmd.Parameters.Add("@ID_TransactionHeader_Invoice", SqlDbType.BigInt).Value = ID_TransactionHeader_Invoice
                cmd.CommandType = CommandType.StoredProcedure
                Using da1 As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da1.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function SetQuotation_TransactionDetail(ByVal ID_TransactionHeader As Long, ByVal ID_Company As Long, ByVal ID_Product As Long, ByVal Unity As String,
           ByVal Description As String, ByVal Quantity As Decimal, ByVal PriceWithIVA As Decimal, ByVal PriceWithoutIva As Decimal, ByVal Discount As Decimal,
           ByVal TotalAmount As Decimal, ByVal Exempt As Boolean, ByVal BusinessDay As Date, ByVal COTRANS As Decimal, ByVal FOVIAL As Decimal,
           ByVal EndTransaction As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice_Quotation_TransactionDetail", conn)
                cmd.Parameters.Add("@ID_TransactionHeader_FK", SqlDbType.BigInt).Value = ID_TransactionHeader
                cmd.Parameters.Add("@ID_Company_FK", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@ID_Product_FK", SqlDbType.BigInt).Value = ID_Product
                cmd.Parameters.Add("@Unity", SqlDbType.VarChar).Value = Unity
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@Quantity", SqlDbType.Money).Value = Quantity
                cmd.Parameters.Add("@PriceWithIVA", SqlDbType.Money).Value = PriceWithIVA
                cmd.Parameters.Add("@PriceWithoutIva", SqlDbType.Money).Value = PriceWithoutIva
                cmd.Parameters.Add("@Discount", SqlDbType.Money).Value = Discount
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Money).Value = TotalAmount
                cmd.Parameters.Add("@Exempt", SqlDbType.Money).Value = Exempt
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.Parameters.Add("@COTRANS", SqlDbType.Money).Value = COTRANS
                cmd.Parameters.Add("@FOVIAL", SqlDbType.Money).Value = FOVIAL
                cmd.Parameters.Add("@EndTransaction", SqlDbType.Bit).Value = EndTransaction


                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK|" & CType(ds.Tables("datos").Rows(0).Item(0), Long).ToString("0000000000")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    REM ===========================================================================
    REM === Compras
    REM ===========================================================================
    Public Function GetInvoice_PurchasesHeader_Select(ByVal Id_Company As Long, ByVal BusinessDay As Date) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_SP_Invoice_Purchases_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.CommandType = CommandType.StoredProcedure
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
    Public Function SetPurchases_TransactionHeader(ByVal Id_Company As Long,
                                                   ByVal AccountingPeriod As String,
                                                   ByVal DocumentNumber As Long,
                                                   ByVal PurchaseType As String,
                                                   ByVal StatusTransaction As Boolean,
                                                   ByVal BusinessDay As Date,
                                                   ByVal ReasonRefund As String,
                                                   ByVal ID_PaymentType As Long,
                                                   ByVal ID_Customer As Long,
                                                   ByVal Fullpayment As Decimal,
                                                   ByVal IVA_Paid As Decimal,
                                                   ByVal Fovial As Decimal,
                                                   ByVal Cotrans As Decimal,
                                                   ByVal SUBTOTAL As Decimal,
                                                   ByVal ExemptSales As Decimal,
                                                   ByVal Retention As Decimal,
                                                   ByVal CESC As Decimal) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Invoice__Purchases_TransactionHeader", conn)

                cmd.Parameters.Add("@ID_Company_FK", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@AccountingPeriod", SqlDbType.VarChar).Value = AccountingPeriod
                cmd.Parameters.Add("@DocumentNumber", SqlDbType.VarChar).Value = DocumentNumber
                cmd.Parameters.Add("@PurchaseType", SqlDbType.VarChar).Value = PurchaseType
                cmd.Parameters.Add("@StatusTransaction", SqlDbType.Bit).Value = StatusTransaction
                cmd.Parameters.Add("@BusinessDay", SqlDbType.Date).Value = BusinessDay
                cmd.Parameters.Add("@ReasonRefund", SqlDbType.VarChar).Value = ReasonRefund
                cmd.Parameters.Add("@ID_PaymentType_FK", SqlDbType.BigInt).Value = ID_PaymentType
                cmd.Parameters.Add("@ID_Customer_FK", SqlDbType.BigInt).Value = ID_Customer
                cmd.Parameters.Add("@Fullpayment", SqlDbType.Money).Value = Fullpayment
                cmd.Parameters.Add("@IVA_Paid", SqlDbType.Money).Value = IVA_Paid
                cmd.Parameters.Add("@Fovial", SqlDbType.Money).Value = Fovial
                cmd.Parameters.Add("@Cotrans", SqlDbType.Money).Value = Cotrans

                cmd.Parameters.Add("@SUBTOTAL", SqlDbType.Money).Value = SUBTOTAL
                cmd.Parameters.Add("@ExemptSales", SqlDbType.Money).Value = ExemptSales
                cmd.Parameters.Add("@Retention", SqlDbType.Money).Value = Retention

                cmd.Parameters.Add("@cesc", SqlDbType.Money).Value = CESC


                REM cmd.Parameters.Add("@DocumentNumber", SqlDbType.BigInt).Value = DocumentNumber
                cmd.CommandType = CommandType.StoredProcedure
                Using da1 As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da1.Fill(ds, "datos")
                            Return "OK|" & CType(ds.Tables("datos").Rows(0).Item(0), Long).ToString("0000000000")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region
#Region "ReportCloseYearCurrent"
    Public Function GetFinance_Ledger_History_SumValue(ByVal ID_Company As Long, ByVal YearPeriod As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Ledger_History_SumValue", conn)

                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@YearPeriod", SqlDbType.VarChar).Value = YearPeriod
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region
#Region "Reports"
    REM  []
    Public Function GetFinance_ReportBalance_History(ByVal ID_Company As Long, ByVal LengthGreaterAccount As Integer, ByVal YearPeriod As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_ReportBalance_History", conn)

                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@LengthGreaterAccount", SqlDbType.Int).Value = LengthGreaterAccount
                cmd.Parameters.Add("@PeriodClose", SqlDbType.VarChar).Value = YearPeriod
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "BalanceGeneral")
                            Return ds.Tables("BalanceGeneral")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetFinance_ReportAccountingHigh_History(ByVal ID_Company As Long, ByVal LengthGreaterAccount As Integer, ByVal YearPeriod As String, ByVal AccountingAll As Boolean) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_ReportAccountingHigh_History", conn)

                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@AccountingAll", SqlDbType.Bit).Value = AccountingAll
                cmd.Parameters.Add("@LengthGreaterAccount", SqlDbType.Int).Value = LengthGreaterAccount
                cmd.Parameters.Add("@PeriodClose", SqlDbType.VarChar).Value = YearPeriod
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
    Public Function GetFinance_Reports_Subledger_History(ByVal ID_Company As Long, ByVal YearPeriod As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Reports_Subledger_History", conn)

                cmd.Parameters.Add("@ID_Company", SqlDbType.BigInt).Value = ID_Company
                cmd.Parameters.Add("@PeriodClose", SqlDbType.VarChar).Value = YearPeriod
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Cuentas por pagar"
    Public Function GetListClient(ByVal Id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_AP_GetCustomerList", conn)
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

    Public Function AddDetailsAccountsPayable(ByVal ID_AccountsList_FK As Integer, ByVal QuotaNumber As Double, ByVal PaymentDate As Date, ByVal Ammount As Double) As Integer
        Dim resp As Integer = 0
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_AddAccountsPayableDetails", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_AccountsPayableList_FK", ID_AccountsList_FK)
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

    Public Function GetRestanteAccountsPayable(ByVal ID_AccountsPayable As Long) As DataTable
        Dim DT_Resp As New DataTable
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("ERP_AP_GetPaymentData", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayable", ID_AccountsPayable)
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

    Public Function InsertAccountPayableQuota(ByVal ID_AccountPayable As Long, ByVal Id_AccountPayableQuota As Long, ByVal Id_Company As Long, ByVal Id_PaymentType As Long, ByVal Fecha_pago As String, ByVal N_Cheque As String, ByVal Id_Empleado As Long) As String
        Dim ds As New DataSet
        Dim res As String = ""
        Dim fechaN As Date = Date.Parse(Fecha_pago).ToString("dd-MM-yyyy")
        Try
            Using da As New SqlDataAdapter("ERP_AP_AddPayoutQuota", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayable", ID_AccountPayable)
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayableListDetails", Id_AccountPayableQuota)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_paymentType", Id_PaymentType)
                da.SelectCommand.Parameters.AddWithValue("@Fecha_pago", fechaN)
                da.SelectCommand.Parameters.AddWithValue("@N_cheque", N_Cheque)
                da.SelectCommand.Parameters.AddWithValue("@Id_Empleado", Id_Empleado)
                da.Fill(ds, "InsertAccountPayableQuota")
                res = ds.Tables("InsertAccountPayableQuota").Rows(0).Item(0)
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

    Public Function InsertAccountPayableFinalize(ByVal _Id_AccountPayable As Long, ByVal Id_Company As Long, ByVal Id_PaymentType As Long, ByVal Fecha_pago As String, ByVal N_Cheque As String, ByVal Id_Empleado As Long) As String
        Dim ds As New DataSet
        Dim res As String = ""
        Dim fechaN As Date = Date.Parse(Fecha_pago).ToString("dd-MM-yyyy")
        Try
            Using da As New SqlDataAdapter("ERP_AP_AddAccountsPayableFinalize", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountPayable", _Id_AccountPayable)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_paymentType", Id_PaymentType)
                da.SelectCommand.Parameters.AddWithValue("@Fecha_pago", fechaN)
                da.SelectCommand.Parameters.AddWithValue("@N_cheque", N_Cheque)
                da.SelectCommand.Parameters.AddWithValue("@Id_Empleado", Id_Empleado)
                da.Fill(ds, "InsertAccountPayableFinalize")
                res = ds.Tables("InsertAccountPayableFinalize").Rows(0).Item(0)
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

#End Region

#Region "Project"
    Public Function GetFinance_ProjectList(ByVal ID_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_ProjectList_Select", conn)

                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = ID_Company

                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos")
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
#End Region

#Region "Pagos Parciales"
    Public Function ERP_Finance_PartialPayments(ByVal ID_Customer_FK As Long, ByVal paymentDate As Date, ByVal Ammount As Double, ByVal CustomerSignature As Boolean, ByVal SalesSignature As Boolean, ByVal Typistsignature As Boolean) As DataTable
        Dim resp As Long = 0
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Finance_PartialPayments", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer_FK)
                da.SelectCommand.Parameters.AddWithValue("@paymentDate", paymentDate)
                da.SelectCommand.Parameters.AddWithValue("@Ammount", Ammount)
                da.SelectCommand.Parameters.AddWithValue("@CustomerSignature", CustomerSignature)
                da.SelectCommand.Parameters.AddWithValue("@SalesSignature", SalesSignature)
                da.SelectCommand.Parameters.AddWithValue("@Typistsignature", Typistsignature)
                da.Fill(ds, "insert")
                dt = ds.Tables("insert")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function ERP_Finance_PartialPaymentsDetails(ByVal ID_Customer As Long, ByVal MontoAbono As Double, ByVal ID_PartialPayments As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Finance_PartialPaymentsDetails", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@MontoAbono", MontoAbono)
                da.SelectCommand.Parameters.AddWithValue("@ID_PartialPayments", ID_PartialPayments)
                da.Fill(ds, "SetOutletCatalog")
                dt = ds.Tables(0)
            End Using
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

#Region "Reporte Pagos Parciales y Estado de cuenta"
    Public Function ERP_Finance_Report_PartialPayments(ByVal ID_Customer As Long, ByVal paymentDateInit As Date, ByVal paymentDateFinish As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Report_PartialPayments", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@paymentDateInit", paymentDateInit)
                da.SelectCommand.Parameters.AddWithValue("@paymentDateFinish", paymentDateFinish)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function ERP_Finance_Reports_AccountStatusMonth(ByVal ID_Customer As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Reports_AccountStatusMonth", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
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

#Region "Orden de produccion"
    Public Function ERP_Prod_SP_ProductionOrderDeliveryCustomer(ByVal Fecha As Date, ByVal ID_Empleado As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ProductionOrderDeliveryCustomer", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.SelectCommand.Parameters.AddWithValue("@ID_Empleado", ID_Empleado)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function ERP_Prod_SP_ProductionOrderDeliveryCustomerUpdate(ByVal ID_TransactionDetail As Long, ByVal Quantity As Double) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ProductionOrderDeliveryCustomerUpdate", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_TransactionDetail", ID_TransactionDetail)
                da.SelectCommand.Parameters.AddWithValue("@Quantity", Quantity)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function ERP_Prod_SP_ProductionOrderDelivery(ByVal Fecha As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ProductionOrderDelivery", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function ERP_Prod_SP_ProductionOrder(ByVal Fecha As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ProductionOrder", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

    Public Function ERP_Prod_SP_ProductionOrderDeliveryReport(ByVal Fecha As Date) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet("SetOutletCatalog")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ProductionOrderDeliveryReport", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds, "report")
                dt = ds.Tables(0)
            End Using
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
#Region "Cuentas por Cobrar"

    Public Function ReporteDeudaPorVendedor(idcompany As Long, idemployee As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_AR_ReportDeudasPorVendedor", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Employee", idemployee)
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", idcompany)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ReporteDeudaPorCliente(idcustomer As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_AR_ReportDeudasPorCliente", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", idcustomer)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function
#End Region

#Region "Reportes"

    Public Function ERP_SP_Inventory_Report_CatalogueFinancialCustomers() As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_SP_Inventory_Report_CatalogueFinancialCustomers", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function


    Public Function ERP_Finance_DailySales(ByVal Fecha As Date) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_Finance_DailySales", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function



    Public Function ERP_Finance_DailySalesSUM(ByVal Fecha As Date) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_Finance_DailySalesSUM", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ERP_AP_Report_PaymentsCompleted(ByVal ID_Customer As Long, ByVal TipoReporte As Integer, ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_AP_Report_PaymentsCompleted", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@TipoReporte", TipoReporte)
                da.SelectCommand.Parameters.AddWithValue("@StartDate", StartDate)
                da.SelectCommand.Parameters.AddWithValue("@EndDate", EndDate)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ERP_AP_Report_PendingPayments(ByVal ID_Customer As Long, ByVal TipoReporte As Integer) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_AP_Report_PendingPayments", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@TipoReporte", TipoReporte)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function
#End Region

#Region "Config Check"

    Public Function GetConfigCheck_Select(ByVal Id_Company As Long, ByVal ID_Bank As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_ConfigCheck_Select", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_Bank", SqlDbType.BigInt).Value = ID_Bank
                cmd.CommandType = CommandType.StoredProcedure
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
    Public Function SetConfigCheck(ByVal ID_Billing As Long, ByVal Id_Company As Long, ByVal ID_Type_Billing As Long, ByVal Name_Billing As String, Config_XML As String,
                                     ByVal Schema_XML As String, ByVal picture As Byte(), ByVal Is_Active As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_ConfigCheck_Update", conn)
                cmd.Parameters.Add("@ID_Check", SqlDbType.BigInt).Value = ID_Billing
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_Bank", SqlDbType.BigInt).Value = ID_Type_Billing
                cmd.Parameters.Add("@Name_Check", SqlDbType.VarChar).Value = Name_Billing
                cmd.Parameters.Add("@Config_XML", SqlDbType.Xml).Value = Config_XML
                cmd.Parameters.Add("@Schema_XML", SqlDbType.Xml).Value = Schema_XML
                cmd.Parameters.Add("@picture", SqlDbType.Image).Value = picture
                cmd.Parameters.Add("@Is_Active", SqlDbType.Bit).Value = Is_Active
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function CreateConfigCheck(ByVal Id_Company As Long, ByVal ID_Type_Billing As Long, ByVal Name_Billing As String, Config_XML As String,
                                     ByVal Schema_XML As String, ByVal picture As Byte(), ByVal Is_Active As Boolean) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_ConfigCheck_Insert", conn)
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@ID_Bank", SqlDbType.BigInt).Value = ID_Type_Billing
                cmd.Parameters.Add("@Name_Check", SqlDbType.VarChar).Value = Name_Billing
                cmd.Parameters.Add("@Config_XML", SqlDbType.Xml).Value = Config_XML
                cmd.Parameters.Add("@Schema_XML", SqlDbType.Xml).Value = Schema_XML
                cmd.Parameters.Add("@picture", SqlDbType.Image).Value = picture
                cmd.Parameters.Add("@Is_Active", SqlDbType.Bit).Value = Is_Active
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Pagos Mensuales"
    Public Function ERP_Finance_MonthlyPayments(ByVal Month As Integer, ByVal ID_Customer_FK As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_Finance_MonthlyPayments", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Month", Month)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer_FK", ID_Customer_FK)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ERP_Finance_Report_Payments(ByVal Id_Company As Long, ByVal Id_AccountReceivableListDetails As Long, ByVal ID_Customer As Long, ByVal Fecha As Date, ByVal Tipo As Integer) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Report_Payments", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_AccountReceivableListDetails", Id_AccountReceivableListDetails)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@Fecha", Fecha)
                da.SelectCommand.Parameters.AddWithValue("@Tipo", Tipo)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function
#End Region


#Region "Buzon"
    Public Function ERP_AccountsReceivable_GET_PartialPaymentsCatalog(ByVal ID_Company As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_AccountsReceivable_GET_PartialPaymentsCatalog", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function
    Public Function ERP_Generic_Add_RequestBox(ByVal Tipo As Long, ByVal Id_employee As Long, ByVal ID_AccountsDetails_FK As Long, ByVal ID_Catalog_FK As Long, ByVal ID_Check_FK As Long, ByVal commentary As String) As Integer
        Dim ds As New DataSet
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("ERP_Generic_Add_RequestBox", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Tipo", Tipo)
                da.SelectCommand.Parameters.AddWithValue("@Id_employee", Id_employee)
                da.SelectCommand.Parameters.AddWithValue("@ID_AccountsDetails_FK", ID_AccountsDetails_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Catalog_FK", ID_Catalog_FK)
                da.SelectCommand.Parameters.AddWithValue("@ID_Check_FK", ID_Check_FK)
                da.SelectCommand.Parameters.AddWithValue("@commentary", commentary)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function

    Public Function ERP_Finance_Request() As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Request", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ERP_Finance_RequestUpdate(ByVal ID_Request As Long, ByVal user_Approved As String, ByVal IS_Approved As Boolean) As Integer
        Dim ds As New DataSet
        Dim resp As Integer = 0
        Try
            Using da As New SqlDataAdapter("ERP_Finance_RequestUpdate", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Request", ID_Request)
                da.SelectCommand.Parameters.AddWithValue("@user_Approved", user_Approved)
                da.SelectCommand.Parameters.AddWithValue("@IS_Approved", IS_Approved)
                da.Fill(ds)
                resp = ds.Tables(0).Rows(0).Item("resp")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return resp
    End Function
#End Region

#Region "historico de ventas"

    Public Function ERP_Finance_Report_SalesHistory() As DataSet
        Dim ds As New DataSet

        Try
            Using da As New SqlDataAdapter("ERP_Finance_Report_SalesHistory", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(ds)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return ds
    End Function
#End Region

    Public Function ERP_SP_Invoice_Quotation_Transaction_Report(Id_Company As Long, ID_Customer As Long, DateStart As Date, DateEnd As Date) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_SP_Invoice_Quotation_Transaction_Report", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Customer", ID_Customer)
                da.SelectCommand.Parameters.AddWithValue("@DateStart", DateStart)
                da.SelectCommand.Parameters.AddWithValue("@DateEnd", DateEnd)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ERP_Finance_Report_LogEntriesAndExitsAnalisis(ByVal Anio As Integer) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_Finance_Report_LogEntriesAndExitsAnalisis", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Anio", Anio)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

#Region "Devolución de productos"
    Public Function ERP_SP_Get_Invoice_TransactionDetail(id_TransactionHeader) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_SP_Get_Invoice_TransactionDetail", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_TransactionDetail_Header", id_TransactionHeader)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

    Public Function ERP_SP_Inventory_RecoverProducts(id_TransactionHeader, id_transactiondetail) As String
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SP_Inventory_RecoverProducts", conn)
                cmd.Parameters.Add("@id_TransactionHeader", SqlDbType.BigInt).Value = id_TransactionHeader
                cmd.Parameters.Add("@id_transactiondetail", SqlDbType.BigInt).Value = id_transactiondetail


                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return "OK"
                        Catch ex As SqlException
                            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error de conexion"
                        Catch ex As Exception
                            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            process.AlmacenarLog(5, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return "ER|Error al cargar la informacion"
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

#End Region

    Public Function ERP_SP_Invoice_Quotation_CLEAN_TransactionDetail(ByVal ID_TransactionHeader_FK As Long) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_SP_Invoice_Quotation_CLEAN_TransactionDetail", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_TransactionHeader_FK", ID_TransactionHeader_FK)
                da.Fill(ds, "data")
            End Using
        Catch ex As SqlException
            MessageBox.Show("Fallo en la conexión con la base de datos, comuniquese con soporte tecnico.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al cargar la informacion.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            process.AlmacenarLog(2, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
        Return dt
    End Function

#Region "Libros de IVA"
    Public Function Book_Shopping_Taxpayer_Select(ByVal Id_Company As Long, ByVal Period As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_SP_Book_Shopping_Taxpayer_Select", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure

                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Period", Period)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function
    Public Function Book_Taxpayer_Sales_Select(ByVal Id_Company As Long, ByVal Period As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_SP_Book_Taxpayer_Sales_Select", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@Period", Period)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function
    Public Function Book_Purchases_Taxpayer_Select(ByVal Id_Company As Long, ByVal Period As Long) As DataTable
        Dim ds As New DataSet
        Dim dt As DataTable = Nothing
        Try
            Using da As New SqlDataAdapter("ERP_SP_Book_Purchases_Taxpayer_Select", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                da.SelectCommand.Parameters.AddWithValue("@AccountingPeriod", Period)
                da.Fill(ds)
                dt = ds.Tables(0)
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return Nothing
        End Try
        Return dt
    End Function

#End Region
#Region "Reportes Genericos"
    Public Function ERP_RRHH_GetGenericReportHeader() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetGenericReportHeader", conn)
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

    Public Function ERP_RRHH_GetGenericReportHeaderModule() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_RRHH_GetGenericReportHeaderModule", conn)
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

    Public Function GetModulo() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_GetModulo", conn)
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

    Public Function ERP_RRHH_Getgeneric_Report_DefineField() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Generic_SP_Get_Generic_Report_DefineField", conn)
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
#End Region


    Public Function ERP_Finance_Get_DepreciationFixedAsset(ByVal Id_FixedAsset_FK As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_DepreciationFixedAsset", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAsset", SqlDbType.BigInt).Value = Id_FixedAsset_FK
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "detalle")
                            Return ds.Tables("detalle")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("detalle")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_Finance_Get_DepreciationFixedAssetIndividual(ByVal Id_FixedAsset_FK As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_Get_DepreciationFixedAssetIndividual", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAsset", SqlDbType.BigInt).Value = Id_FixedAsset_FK
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "detalle")
                            Return ds.Tables("detalle")
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return New DataTable("detalle")
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_Generic_SP_Get_Generic_Report_DefineField_Update(ByVal i As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("[ERP_Generic_SP_Get_Generic_Report_DefineField_Update]", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Header_FK", SqlDbType.BigInt).Value = i

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
#Region "Reportes de Activos y Legacy"
    Public Function ERP_Finance_FixedAssetByEmploye(ByVal id_Company As Long, ByVal id_employee As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_GETInventaryByEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_employee", SqlDbType.BigInt).Value = id_employee
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
    Public Function ERP_Finance_FixedAssetByEmployeLegacy(ByVal id_Company As Long, ByVal id_employee As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_GETInventaryByEmployeeLegacy", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_employee", SqlDbType.BigInt).Value = id_employee
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


    Public Function ERP_InventoryTrasnsersFixedAsset(
                                                    ByVal id_previous_responsible_FK As Integer,
                                                     ByVal initial_owner_date As Date,
                                                     ByVal id_actual_responsible_FK As Integer,
                                                     ByVal id_reason_FK As Integer,
                                                     ByVal ID_FixedAssets_FK As Integer,
                                                     ByVal descripcionTrasferencia As String,
                                                     ByVal condicionante As Boolean,
                                                     ByVal IdUbicacionPrimaria As Integer,
                                                     ByVal IdUbicacionSecundaria As Integer) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_InventoryTrasnsersFixedAsset", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_previous_responsible_FK", SqlDbType.BigInt).Value = id_previous_responsible_FK
                cmd.Parameters.Add("@initial_owner_date", SqlDbType.Date).Value = initial_owner_date
                cmd.Parameters.Add("@id_actual_responsible_FK", SqlDbType.BigInt).Value = id_actual_responsible_FK
                cmd.Parameters.Add("@id_reason_FK", SqlDbType.BigInt).Value = id_reason_FK
                cmd.Parameters.Add("@ID_FixedAssets_FK", SqlDbType.BigInt).Value = ID_FixedAssets_FK
                cmd.Parameters.Add("@descripcionTrasferencia", SqlDbType.VarChar).Value = descripcionTrasferencia
                cmd.Parameters.Add("@condicionante", SqlDbType.Bit).Value = condicionante
                cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = _UserSQL
                cmd.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = "MAIL_CreacionTransferencia"
                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@IdUbicacionPrimaria", SqlDbType.BigInt).Value = IdUbicacionPrimaria
                cmd.Parameters.Add("@IdUbicacionSecundaria", SqlDbType.BigInt).Value = IdUbicacionSecundaria

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Dim EnvioCorreo As New SendEmail
                            If ds.Tables.Count > 0 Then
                                If ds.Tables("datos").Rows.Count > 0 Then
                                    For Each DataInfo As DataRow In ds.Tables("datos").Rows
                                        EnvioCorreo.SendEmail(DataInfo("email"), DataInfo("Subject"), DataInfo("Body"), ID_FixedAssets_FK)
                                    Next
                                End If
                            End If
                            Return 1
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 3
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function



    Public Function ERP_SetInventoryTrasnfer(ByVal id_transfers As Integer,
                                             ByVal id_actual_responsible_FK As Integer,
                                             ByVal ID_FixedAssets_FK As Integer,
                                             ByVal id_previous_responsible_FK As Integer,
                                             ByVal Description As String, Optional estado As Integer = 0,
                                             Optional IdLocationPrimary As Integer = 0, Optional IdLocationSecondary As Integer = 0) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_SetInventoryTrasnfer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_transfers", SqlDbType.BigInt).Value = id_transfers
                cmd.Parameters.Add("@id_actual_responsible_FK", SqlDbType.BigInt).Value = id_actual_responsible_FK
                cmd.Parameters.Add("@ID_FixedAssets_FK", SqlDbType.BigInt).Value = ID_FixedAssets_FK
                cmd.Parameters.Add("@id_previous_responsible_FK", SqlDbType.BigInt).Value = id_previous_responsible_FK
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado
                cmd.Parameters.Add("@IdLocationPrimary", SqlDbType.Int).Value = IdLocationPrimary
                cmd.Parameters.Add("@IdLocationSecondary", SqlDbType.Int).Value = IdLocationSecondary
                cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = _UserSQL
                If estado = 3 Then
                    cmd.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = "MAIL_AprobacionTransferencia"
                ElseIf estado = 4 Then
                    cmd.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = "MAIL_AprobacionTransferenciaRechazo"
                ElseIf estado = 5 Then
                    cmd.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = "MAIL_AutorizacionTransferencia"
                ElseIf estado = 6 Then
                    cmd.Parameters.Add("@Acceso", SqlDbType.VarChar).Value = "MAIL_AutorizacionRechazo"
                End If

                cmd.Parameters.Add("@Id_Department", SqlDbType.BigInt).Value = _Id_DepartmentGlobal
                cmd.Parameters.Add("@Id_EmployeeGlobal", SqlDbType.BigInt).Value = _Id_EmployeeGlobal
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Dim EnvioCorreo As New SendEmail
                            If ds.Tables.Count > 0 Then
                                If ds.Tables("datos").Rows.Count > 0 Then
                                    For Each DataInfo As DataRow In ds.Tables("datos").Rows
                                        Try
                                            EnvioCorreo.SendEmail(DataInfo("email"), DataInfo("Subject"), DataInfo("Body"), ID_FixedAssets_FK)
                                        Catch ex As Exception
                                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                                            Return 3
                                        End Try
                                    Next
                                End If
                            End If
                            Return 1
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 3
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_GetActivoInventoryTrasnferReport(ByVal id_fixedAssets As Long, ByVal id_transfers As Long, ByVal Autorizacion As Integer) As DataSet
        Dim ds As New DataSet
        Try
            Using da As New SqlDataAdapter("ERP_GetActivoInventoryTrasnferReport", connStr)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_fixedAssets", id_fixedAssets)
                da.SelectCommand.Parameters.AddWithValue("@id_transfers", id_transfers)
                da.SelectCommand.Parameters.AddWithValue("@Autorizacion", Autorizacion)
                da.Fill(ds, "datos")
            End Using
        Catch ex As Exception
            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
            Return New DataSet
        End Try
        Return ds
    End Function


    Public Function ERP_GetInventoryTransferinProcess_FixedAssets(ByVal Id_Company As Integer, ByVal Busquedad As String, ByVal Id_Department As Integer, ByVal Id_Employee As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_GetInventoryTransferinProcess_FixedAssets", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
                    da.SelectCommand.Parameters.AddWithValue("@busqueda", Busquedad)
                    da.SelectCommand.Parameters.AddWithValue("@Id_Department", Id_Department)
                    da.SelectCommand.Parameters.AddWithValue("@Id_Employee", Id_Employee)
                    da.SelectCommand.Parameters.AddWithValue("@Id_EmployeeGlobal", _Id_EmployeeGlobal)
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

    Public Function ERP_GetFixedAssetsSinAginacion() As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_GetFixedAssetsSinAginacion", conn)
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

    Property id_transfer As Integer
    Public Function ERP_validarSiExisteTransfereciaDeActivo(ByVal id_fixedAssets As Long) As Boolean
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_validarSiExisteTransfereciaDeActivo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_fixedAssets", SqlDbType.BigInt).Value = id_fixedAssets
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            If ds.Tables("datos").Rows(0).Item(0) = 0 Then
                                Return False 'NO ESTA EN PROCESO TRANSF
                            Else
                                id_transfer = ds.Tables("datos1").Rows(0).Item(0)
                                Return True 'ESTA EN PROCESO DE TRANSF
                            End If


                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return False
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Function ERP_validarSiTienePermisosTransferenciaDeActivo(ByVal id_employe_FK As Long) As Boolean
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_validarSiTienePermisosTransferenciaDeActivo", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_employe", SqlDbType.BigInt).Value = id_employe_FK
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables("datos").Rows(0).Item(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return False
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_GetActivoInventoryTrasnfer(ByVal id_fidexAsset As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_GetActivoInventoryTrasnfer", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@id_fixedAssets", SqlDbType.BigInt).Value = id_fidexAsset
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


    Public Function ERP_GetIndicadorEmployee_FixedAssets(ByVal Id_Company As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_IndicatorEmployee", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
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


    Public Function ERP_GetIndicadorDepartment_FixedAssets(ByVal Id_Company As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_IndicatorDepartment", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
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


    Public Function ERP_GetIndicadorState_FixedAssets(ByVal Id_Company As Integer) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_FixedAssets_SP_IndicatorState", conn)
                cmd.CommandType = CommandType.StoredProcedure

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    da.SelectCommand.Parameters.AddWithValue("@Id_Company", Id_Company)
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


#Region "Depreciacion"
    Public Function ERP_Finance_Get_FixedAssetDepreciation(ByVal Id_HeaderDepreciation As Integer) As DataSet
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_Finance_Get_DepreciationFixedAssets", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.Int).Value = _ID_Company
                cmd.Parameters.Add("@Id_HeaderDepreciation", SqlDbType.Int).Value = Id_HeaderDepreciation
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
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

    Public Function ERP_Finance_Set_FixedAssetDepreciationHeader(ByVal DateProcess As Date, ByVal Description As String,
                                                                 ByVal ActualizarEstadoHeader As Integer, ByVal id_headerdepreciation_FK As Integer) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_Finance_Set_FixedAssetDepreciationHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.Int).Value = _ID_Company
                cmd.Parameters.Add("@dateProcess", SqlDbType.Date).Value = DateProcess
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@id_employee_fk", SqlDbType.Int).Value = _Id_EmployeeGlobal
                cmd.Parameters.Add("@ActualizarEstadoHeader", SqlDbType.Int).Value = ActualizarEstadoHeader
                cmd.Parameters.Add("@id_headerdepreciation_FK", SqlDbType.Int).Value = id_headerdepreciation_FK


                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function


    Public Function ERP_Finance_Set_FixedAssetDepreciationIndividual(ByVal Id_FixedAssets As Integer, ByVal Id_HeaderDepreciation_FK As Integer, ByVal FechaDepreciacion As Date) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_Finance_Set_DepreciationFixedAssetIndividual", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_FixedAssets", SqlDbType.Int).Value = Id_FixedAssets
                cmd.Parameters.Add("@Id_HeaderDepreciation_FK", SqlDbType.Int).Value = Id_HeaderDepreciation_FK
                cmd.Parameters.Add("@FechaDepreciacion", SqlDbType.Date).Value = Date.Parse(FechaDepreciacion).ToString("yyyy-MM-dd")

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


    Public Function ERP_Finance_Set_FixedAssetDepreciationIndividual(ByVal Valor As Decimal, ByVal ValorResidual As Decimal, ByVal VidaUtil As Integer, ByVal ANO As Integer, ByVal DateFacture As Date, ByVal TipoCalculo As Integer, ByVal id_headerdepreciation_FK As Integer, ByVal ID_FixedAssets_FK As Integer, ByVal FechaProceso As Date, ByVal VidaUtilDias As Integer) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_Finance_Set_DepreciationFixedAssets", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Valor", SqlDbType.Money).Value = Valor
                cmd.Parameters.Add("@ValorResidual", SqlDbType.Money).Value = ValorResidual
                cmd.Parameters.Add("@VidaUtilAnios", SqlDbType.BigInt).Value = VidaUtil
                cmd.Parameters.Add("@ano", SqlDbType.BigInt).Value = ANO
                cmd.Parameters.Add("@DateFacture", SqlDbType.Date).Value = DateFacture
                cmd.Parameters.Add("@TipoCalculo", SqlDbType.Int).Value = TipoCalculo
                cmd.Parameters.Add("@id_headerdepreciation_FK", SqlDbType.Int).Value = id_headerdepreciation_FK
                cmd.Parameters.Add("@ID_FixedAssets_FK", SqlDbType.Int).Value = ID_FixedAssets_FK
                cmd.Parameters.Add("@FechaProceso", SqlDbType.Date).Value = FechaProceso
                cmd.Parameters.Add("@VidaUtilDias", SqlDbType.BigInt).Value = VidaUtilDias
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


    Public Function GetFinance_DepreciationPendAproved(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_SP_GetPendAprovedDeprec", conn)
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

    Public Function GetFinance_HeaderDepreciation(ByVal id_Company As Long, ByVal Busquedad As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_SP_GetHeaderDepreciation", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
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

#End Region


#Region "Amortización"
    Public Function ERP_Finance_Set_FixedAssetAmortizacionHeader(ByVal DateProcess As Date, ByVal Description As String,
                                                                 ByVal ActualizarEstadoHeader As Integer, ByVal id_headerdepreciation_FK As Integer, ByVal IdString As String) As Integer
        Using conn As New SqlClient.SqlConnection(connStr)

            Using cmd As New SqlCommand("ERP_Finance_Set_FixedAssetAmortizacionHeader", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.Int).Value = _ID_Company
                cmd.Parameters.Add("@dateProcess", SqlDbType.Date).Value = DateProcess
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description
                cmd.Parameters.Add("@id_employee_fk", SqlDbType.Int).Value = _Id_EmployeeGlobal
                cmd.Parameters.Add("@ActualizarEstadoHeader", SqlDbType.Int).Value = ActualizarEstadoHeader
                cmd.Parameters.Add("@id_headerAmortizacion_FK", SqlDbType.Int).Value = id_headerdepreciation_FK
                cmd.Parameters.Add("@IdString", SqlDbType.VarChar).Value = IdString

                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Using ds As New DataSet
                        Try
                            da.Fill(ds, "datos")
                            Return ds.Tables(0).Rows(0).Item(0)
                        Catch ex As Exception
                            process.AlmacenarLog(4, ex.ToString, System.Reflection.MethodBase.GetCurrentMethod().Name)
                            Return 0
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function





    Public Function GetFinance_AmortizacionPendAproved(ByVal id_Company As Long) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_SP_GetPendAprovedAmotizacion", conn)
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

    Public Function GetFinance_HeaderAmortizacion(ByVal id_Company As Long, ByVal Busquedad As String) As DataTable
        Using conn As New SqlClient.SqlConnection(connStr)
            Using cmd As New SqlCommand("ERP_Finance_SP_GetHeaderAmortizacion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = id_Company
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

#End Region


    Public Function SetMontoAquisicionUpdate(ByVal monto As Long, ByVal descripcion As String) As String

        Dim resp As String = ""
        Dim ds As New DataSet("data")
        Try
            Using da As New SqlDataAdapter("SP_ERP_MontoAdquisicion_Update", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@monto", SqlDbType.BigInt).Value = monto
                da.SelectCommand.Parameters.AddWithValue("@descripcion", SqlDbType.VarChar).Value = descripcion

                da.Fill(ds, "updatemonto")
                resp = ds.Tables("updatemonto").Rows(0).Item("resp")
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
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
