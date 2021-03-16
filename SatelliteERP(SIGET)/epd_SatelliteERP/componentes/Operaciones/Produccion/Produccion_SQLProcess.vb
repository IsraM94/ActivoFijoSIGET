Imports System.Data.SqlClient

Public Class Produccion_SQLProcess : Implements IDisposable

    Dim process As New ProcessGeneral
    Private connStr As String = DataCenter()
    Friend Function DataCenter() As String
        Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Epdsoft\SatelliteERP", "ConnectionStrings", "Error") REM trae el valor del regedit
        Dim a As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Retail Pro\Epdsoft", "ConnectionStrings", "Error")
    End Function
    Public Function Production_GetListProducts(ByVal ID_Company As Long, ByVal ID_Ciclo As Long) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_Production_GetListProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Ciclo", ID_Ciclo)
                da.Fill(ds, "GetProduct")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function



    Public Function Production_GetHoursProcess(ByVal ID_Company As Long, ByVal ID_Process As Long) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_Production_GetHoursProcess", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@ID_Process", ID_Process)
                da.Fill(ds, "GetHours")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function

    Public Function Production_GetDataLote(ByVal ID_Company As Long, ByVal ID_Lote As Long) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_GetDataLoteGen", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_Lot", ID_Lote)
                da.Fill(ds, "DataLotGen")
            End Using
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_GetDataLote", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Company", ID_Company)
                da.SelectCommand.Parameters.AddWithValue("@Id_Lot", ID_Lote)
                da.Fill(ds, "DataLot")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function

    Public Function Production_AddProducts(ByVal ID_Lot As Long, ByVal ID_Animal As Long, ByVal ID_Process As Long,
                                           ByVal FechaProduction As Date, ByVal Ciclo As Long) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_Production_AddProducts", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", ID_Lot)
                da.SelectCommand.Parameters.AddWithValue("@ID_Animal", ID_Animal)
                da.SelectCommand.Parameters.AddWithValue("@ID_Process", ID_Process)
                da.SelectCommand.Parameters.AddWithValue("@FechaProduction", FechaProduction)
                da.SelectCommand.Parameters.AddWithValue("@Ciclo", Ciclo)
                da.Fill(ds, "LogInsert")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function


    Public Function Production_AddPesosAnimales(ByVal ID_Animal As Long, ByVal ID_Lote As Long, ByVal Id_TipoNacimiento As Integer, ByVal Peso As Double) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_Production_AddPesosAnimales", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Animal", ID_Animal)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lote", ID_Lote)
                da.SelectCommand.Parameters.AddWithValue("@Id_TipoNacimiento", Id_TipoNacimiento)
                da.SelectCommand.Parameters.AddWithValue("@Peso", Peso)
                da.Fill(ds, "LogErr")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function


    Public Function Production_UpdateAnimalData(ByVal ID_Animal As Long, ByVal ID_Lote As Long, ByVal Temperatura As Double, ByVal TiempoParto As Double) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Update_DataAnimal", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Animal", ID_Animal)
                da.SelectCommand.Parameters.AddWithValue("@Id_Company", ID_Lote)
                da.SelectCommand.Parameters.AddWithValue("@Temperature", Temperatura)
                da.SelectCommand.Parameters.AddWithValue("@TimeBirth", TiempoParto)
                da.Fill(ds, "UpdateDataAnimal")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function

    Public Function Production_GetResumenProduct(ByVal ID_Etapa As Long) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_Report_Scheduled", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Etapa", ID_Etapa)
                da.Fill(ds, "LogErr")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function

    Public Function Production_GetAnimalsEtapa(ByVal ID_Etapa As Long, ByVal Id_Lot As Long, ByVal Ciclo As Integer) As DataSet
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("SP_Production_GetAnimalsEtapa", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Etapa", ID_Etapa)
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", Id_Lot)
                da.SelectCommand.Parameters.AddWithValue("@Ciclo", Ciclo)
                da.Fill(ds, "data")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds
    End Function


    Public Function Production_GetTipoNacimiento() As DataTable
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_ProcessTypeBirth", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Activo", 1)
                da.Fill(ds, "TypeBirth")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds.Tables(0)
    End Function

    Public Function Production_GetPesosAnimales(ByVal Id_Animal As Long, ByVal Id_Lote As Long) As DataTable
        Dim ds As New DataSet("Err")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Select_AnimalWeights", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_Animal", Id_Animal)
                da.SelectCommand.Parameters.AddWithValue("@Id_Lote", Id_Lote)
                da.Fill(ds, "AnimalWeights")
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return ds.Tables(0)
    End Function

	Public Function Production_ProcessProducts(ByVal ID_Animal As Long, ByVal ID_Etapa As Long, ByVal Id_Lot As Long, ByVal Ciclo As Long, ByVal ID_Barraco As Long) As DataSet
		Dim ds As New DataSet("Err")
		Try
			Using da As New SqlDataAdapter("SP_Production_ProcessProducts", New SqlClient.SqlConnection(connStr))
				da.SelectCommand.CommandType = CommandType.StoredProcedure
				da.SelectCommand.Parameters.AddWithValue("@ID_Animal", ID_Animal)
				da.SelectCommand.Parameters.AddWithValue("@ID_Etapa", ID_Etapa)
				da.SelectCommand.Parameters.AddWithValue("@ID_Lot", Id_Lot)
				da.SelectCommand.Parameters.AddWithValue("@Ciclo", Ciclo)
				da.SelectCommand.Parameters.AddWithValue("@ID_Barraco", ID_Barraco)
				da.Fill(ds, "data")
			End Using
		Catch ex As SqlException
			MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
			MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
		Return ds
	End Function
	Public Function Production_CompletedPhase(ByVal Id_Lot As Long, ByVal is_complete As Boolean) As String
        Dim ds As New DataSet("Err")
        Dim resp As String = "err"
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_ProductsProcess_CompletedPhase", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ID_Lot", Id_Lot)
                da.SelectCommand.Parameters.AddWithValue("@IS_CompletedPhase", is_complete)
                da.Fill(ds, "data")
                resp = ds.Tables("data").Rows(0)(0)
            End Using
        Catch ex As SqlException
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] Hora: [" & Date.Today.ToString & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            '   My.Computer.FileSystem.WriteAllText(_Address & Path.DirectorySeparatorChar & "ERP.txt", "Fecha: [" & Date.Today & "] [ERR]" & ex.Message.ToString & " Usuario: [" & _User & "]", True)
        End Try
        Return resp
    End Function

#Region "Actualizar estados y Salida de animales del lote"
    Public Function ERP_Prod_SP_Insert_ProcessOutputAnimals(ByVal Id_lotAnimal As Long, ByVal ID_Animal As Long, ByVal ReasonOfExit As String, ByVal Ciclo As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Insert_ProcessOutputAnimals", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@Id_lotAnimal", Id_lotAnimal)
                da.SelectCommand.Parameters.AddWithValue("@ID_Animal", ID_Animal)
                da.SelectCommand.Parameters.AddWithValue("@ReasonOfExit", ReasonOfExit)
                da.SelectCommand.Parameters.AddWithValue("@Ciclo", Ciclo)
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
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


    Public Function ERP_Prod_SP_Update_ProcessActive(ByVal id_lotSelec As Long) As DataTable
        Dim resp As New DataTable
        Dim ds As New DataSet("datos")
        Try
            Using da As New SqlDataAdapter("ERP_Prod_SP_Update_ProcessActive", New SqlClient.SqlConnection(connStr))
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_lotSelec", id_lotSelec)
                da.SelectCommand.Parameters.AddWithValue("@DateProcess", "")
                da.Fill(ds, "tabla")
                resp = ds.Tables("tabla")
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
#End Region

    Public Function Flow_ListProcess(ByVal Id_Company As Long, ByVal Id_Flow As Long) As DataTable
        Dim resp As DataTable
        Using cnn As New SqlConnection(connStr)
            Using cmd As New SqlCommand()
                cmd.Connection = cnn
                cmd.CommandText = "ERP_Prod_SP_Select_Flow_ListProcess"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@Id_Company", SqlDbType.BigInt).Value = Id_Company
                cmd.Parameters.Add("@Id_Flow", SqlDbType.BigInt).Value = Id_Flow
                Using da As New SqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    da.Fill(ds, "ListProcess")
                    Try
                        resp = ds.Tables("ListProcess")
                    Catch ex As Exception
                        REM Adicionar log de error
                    End Try
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
