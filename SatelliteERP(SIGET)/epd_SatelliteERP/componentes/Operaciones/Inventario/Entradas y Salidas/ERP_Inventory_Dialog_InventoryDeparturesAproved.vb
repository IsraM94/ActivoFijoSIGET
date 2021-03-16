Public Class ERP_Inventory_Dialog_InventoryDeparturesAproved
    Private _DT_Outlet As New DataTable
    Private _DT_Product As New DataTable
    Property ID_Stowage As Long = 0
    Private _DT_Products As New DataTable
    Private _IS_Result As Boolean = False
    Private row As DataRow = Nothing
    Private _Quantity As Double = 0
    Private _ID_BodegaSalida As Long = 0
    Private _Name_BodegaSalida As String
    Private IdHeaderSalida As Integer = 0
    Property _AProbacionSalida As Boolean = False
    Private Sub LoadCatalog(ByVal Busquedad As String)
        Using objSQL As New Operaciones_SQLServer
            _DT_Outlet.Rows.Clear()
            _DT_Outlet = objSQL.SP_ERP_Inventory_GetOutletProcess(_ID_Company, Busquedad, 0)
            If Not _DT_Outlet Is Nothing Then
                If _DT_Outlet.Rows.Count > 0 Then


                    If _AProbacionSalida Then

                        Dim qry = From dr As DataRow In _DT_Outlet.AsEnumerable()
                                  Where dr.Field(Of String)("Estado") <> "En Proceso"
                                  Select dr

                        Dim con As Integer = 0
                        Try
                            Dim tablaCalc As New DataTable("Data")

                            tablaCalc = _DT_Outlet.Clone()
                            tablaCalc.Rows.Clear()
                            tablaCalc = qry.CopyToDataTable
                            dgSalidasPro.DataSource = tablaCalc
                        Catch ex As Exception

                        End Try
                    Else
                        dgSalidasPro.DataSource = _DT_Outlet
                    End If


                    dgSalidasPro.Font = New Font("Segoe UI", 11)
                End If
            Else
                MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End Using
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        If dgSalidasPro.CurrentRow IsNot Nothing Then
            '' Dim row() As DataRow
            IdHeaderSalida = dgSalidasPro.CurrentRow.Cells("Id_Output").Value
            Using objSQL As New Operaciones_SQLServer
                _DT_Product = objSQL.SP_ERP_Inventory_GetOutletProcessApro(IdHeaderSalida)
                If Not _DT_Product Is Nothing Then
                    If _DT_Product.Rows.Count > 0 Then
                        If Not dgSalidasPro.CurrentRow Is Nothing Then

                            Using obj As New ERP_Inventory_Dialog_InventoryDepartures
                                obj._DtProductsOutput = _DT_Product
                                obj.AprobarSalida = _AProbacionSalida
                                obj.EstadoSalida = dgSalidasPro.CurrentRow.Cells("Estado").Value.ToString
                                obj.TipoSalida = dgSalidasPro.CurrentRow.Cells("TipoSalida").Value.ToString
                                obj.ComentarioSalida = dgSalidasPro.CurrentRow.Cells("Comentario").Value.ToString
                                obj.ID_Stowage = ID_Stowage
                                obj.IdHeaderSalida = IdHeaderSalida
                                obj.ShowDialog()
                            End Using
                        End If
                    End If

                    LoadCatalog("")
                Else
                    MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End Using
        End If
    End Sub



    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region


    Private Sub cb_FiltroSalidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_FiltroSalidas.SelectedIndexChanged
        Try
            If cb_FiltroSalidas.SelectedItem.ToString = "Todas Salidas" Then
                Using objSQL As New Operaciones_SQLServer
                    _DT_Outlet.Rows.Clear()
                    _DT_Outlet = objSQL.SP_ERP_Inventory_GetOutletProcess(_ID_Company, "", 0)
                    If Not _DT_Outlet Is Nothing Then
                        If _DT_Outlet.Rows.Count > 0 Then

                            If _AProbacionSalida Then
                                Dim qry = From dr As DataRow In _DT_Outlet.AsEnumerable()
                                          Where dr.Field(Of String)("Estado") <> "En Proceso"
                                          Select dr

                                Dim con As Integer = 0
                                Try
                                    Dim tablaCalc As New DataTable("Data")

                                    tablaCalc = _DT_Outlet.Clone()
                                    tablaCalc.Rows.Clear()
                                    tablaCalc = qry.CopyToDataTable
                                    dgSalidasPro.DataSource = tablaCalc
                                Catch ex As Exception

                                End Try
                            Else
                                dgSalidasPro.DataSource = _DT_Outlet
                            End If


                            dgSalidasPro.Font = New Font("Segoe UI", 11)
                        End If
                    Else
                        MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dgSalidasPro.Rows.Clear()
                    End If
                End Using
            ElseIf cb_FiltroSalidas.SelectedItem.ToString = "Salidas en Proceso" Then
                Using objSQL As New Operaciones_SQLServer
                    _DT_Outlet.Rows.Clear()
                    _DT_Outlet = objSQL.SP_ERP_Inventory_GetOutletProcess(_ID_Company, "", 1)
                    If Not _DT_Outlet Is Nothing Then
                        If _DT_Outlet.Rows.Count > 0 Then
                            dgSalidasPro.DataSource = _DT_Outlet
                            dgSalidasPro.Font = New Font("Segoe UI", 11)
                        End If
                    Else
                        MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dgSalidasPro.Rows.Clear()
                    End If
                End Using
            ElseIf cb_FiltroSalidas.SelectedItem.ToString = "Salidas de Revisión" Then
                Using objSQL As New Operaciones_SQLServer
                    _DT_Outlet.Rows.Clear()
                    _DT_Outlet = objSQL.SP_ERP_Inventory_GetOutletProcess(_ID_Company, "", 2)
                    If Not _DT_Outlet Is Nothing Then
                        If _DT_Outlet.Rows.Count > 0 Then
                            dgSalidasPro.DataSource = _DT_Outlet
                            dgSalidasPro.Font = New Font("Segoe UI", 11)
                        End If
                    Else
                        MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dgSalidasPro.Rows.Clear()
                    End If
                End Using
            ElseIf cb_FiltroSalidas.SelectedItem.ToString = "Salidas Aprobadas" Then
                Using objSQL As New Operaciones_SQLServer
                    _DT_Outlet.Rows.Clear()
                    _DT_Outlet = objSQL.SP_ERP_Inventory_GetOutletProcess(_ID_Company, "", 3)
                    If Not _DT_Outlet Is Nothing Then
                        If _DT_Outlet.Rows.Count > 0 Then
                            dgSalidasPro.DataSource = _DT_Outlet
                            dgSalidasPro.Font = New Font("Segoe UI", 11)
                        End If
                    Else
                        MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dgSalidasPro.Rows.Clear()
                    End If
                End Using
            ElseIf cb_FiltroSalidas.SelectedItem.ToString = "Salidas Denegadas" Then
                Using objSQL As New Operaciones_SQLServer
                    _DT_Outlet.Rows.Clear()
                    _DT_Outlet = objSQL.SP_ERP_Inventory_GetOutletProcess(_ID_Company, "", 4)
                    If Not _DT_Outlet Is Nothing Then
                        If _DT_Outlet.Rows.Count > 0 Then
                            dgSalidasPro.DataSource = _DT_Outlet
                            dgSalidasPro.Font = New Font("Segoe UI", 11)
                        End If
                    Else
                        MessageBox.Show("No hay solicitudes pendientes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dgSalidasPro.Rows.Clear()
                    End If
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ERP_Inventory_Dialog_InventoryDeparturesAproved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _AProbacionSalida Then
            cb_FiltroSalidas.Items.RemoveAt(1)
        End If
        LoadCatalog("")
    End Sub

    Private Sub txtBusquedad_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedad.TextChanged
        If txtBusquedad.Text.ToString.Trim.Count > 2 Then
            LoadCatalog(txtBusquedad.Text.ToString.Trim)
        ElseIf txtBusquedad.Text.ToString.Trim.Count = 0 Then
            LoadCatalog("")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReimprimir.Click
        Try
            If dgSalidasPro.CurrentRow IsNot Nothing Then
                '' Dim row() As DataRow
                If dgSalidasPro.CurrentRow.Cells("Estado").Value.ToString = "Aprobado" Then
                    IdHeaderSalida = dgSalidasPro.CurrentRow.Cells("Id_Output").Value
                    Dim dt As New DataTable
                    Using objSQLBodega As New Operaciones_SQLServer
                        dt = objSQLBodega.Inventory_OutputReport(Data_Id_Company, IdHeaderSalida)
                    End Using

                    Using objPartidaContable As New Financiero_ReportViewer(dt, "DSBodegasOperaciones", "epd_SatelliteERP.Reports_InventoryOutPutProduct.rdlc")
                        objPartidaContable.ShowDialog()
                    End Using
                Else
                    MessageBox.Show("La Salida no ha sido Aprobada", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class