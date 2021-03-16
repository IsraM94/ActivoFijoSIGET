Public Class Inventario_fechas
    Public Property Fechainicio As Date
    Public Property FechaFin As Date
    Public Property _IdProducto As Integer
    Public Property _ID_Stowage As Integer
    Public Property _ShowProduct As Boolean = False
    Public Property _IdProveedor As Integer = 0

    Public Property _IdCategory As Integer = 0
    Public Property _TipoInformacion As String = ""
    Public Property _IdDeparment As Integer = 0

    Private _DT_Providers As DataTable = Nothing
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Fechainicio = dtpFechainicio.Value
        FechaFin = dtpFechafin.Value
        _IdProducto = cbxProducto.SelectedValue
        _IdProveedor = cbxProducto.SelectedValue
        _IdDeparment = cbxProducto.SelectedValue
        _IdCategory = cbxProducto.SelectedValue
        If dtpFechainicio.Value > dtpFechafin.Value Then
            MessageBox.Show("La fecha inicio no debe se mayor a la fecha fin", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.DialogResult = DialogResult.OK
        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Function FillCBProviders() As Boolean
        Dim resp As Boolean = False
        Using ObjSQl As New Operaciones_SQLServer
            _DT_Providers = ObjSQl.GetProviders(_ID_Company)
        End Using
        Dim dt_Providers As New DataTable
        dt_Providers.Columns.Add("ID", Type.GetType("System.Int64"))
        dt_Providers.Columns.Add("Description", Type.GetType("System.String"))
        For Each row As DataRow In _DT_Providers.Rows
            If Not row Is Nothing Then
                If Not IsDBNull(row("Is_LegalEntity")) Then
                    If row("Is_LegalEntity") Then
                        dt_Providers.Rows.Add(row("Id_Customer"), row("Name_Company"))
                    End If
                End If
            End If
        Next row

        If dt_Providers.Rows.Count > 0 Then
            Try
                resp = True
                cbxProducto.DataSource = dt_Providers
                cbxProducto.DisplayMember = "Description"
                cbxProducto.ValueMember = "ID"
                cbxProducto.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
        Return resp
    End Function



    Private Function FillCBDepartment() As Boolean
        Dim resp As Boolean = False
        Dim DataInfo As DataTable

        Dim dt As New DataTable
        Dim table2 As DataTable
        Using obj As New Generic_SQLServer
            DataInfo = obj.SP_ERP_Inventary_GetUnidadesOrganizativas()
        End Using

        table2 = DataInfo.Clone()
        table2.Rows.Clear()
        table2.Rows.Add(0, "Todos")
        table2.Merge(DataInfo)

        If table2.Rows.Count > 0 Then
            Try
                resp = True
                cbxProducto.DataSource = table2
                cbxProducto.DisplayMember = "Name_Deparmnet"
                cbxProducto.ValueMember = "Id_Deparment"
                cbxProducto.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
        Return resp
    End Function


    Private Sub FillcbCategory()
        Dim DataInfo As DataTable

        Dim dt As New DataTable
        Dim table2 As DataTable
        Using ObjSQL As New Operaciones_SQLServer
            DataInfo = ObjSQL.GetCategory(_ID_Company)
        End Using

        table2 = DataInfo.Clone()
        table2.Rows.Clear()
        table2.Rows.Add(0, _ID_Company, "Todos")
        table2.Merge(DataInfo)

        If table2.Rows.Count <> 0 Then
            Try
                cbxProducto.DataSource = table2
                cbxProducto.DisplayMember = "Description"
                cbxProducto.ValueMember = "ID"
                cbxProducto.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
    End Sub

    Private Sub Inventario_fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPro.Visible = True
        cbxProducto.Visible = True
        If (_ShowProduct = True) Then
            Using obj As New Operaciones_SQLServer
                If (_TipoInformacion = "Proveedor") Then
                    lblPro.Text = _TipoInformacion
                    FillCBProviders()
                ElseIf (_TipoInformacion = "Departamento") Then
                    lblPro.Text = _TipoInformacion
                    FillCBDepartment()
                ElseIf (_TipoInformacion = "Categorias") Then
                    lblPro.Text = _TipoInformacion
                    FillCBCategory()
                Else
                    Dim _dtMarca As New DataTable
                    _dtMarca = obj.ERP_Inventory_GetProducts_Kardex(Data_Id_Company)
                    cbxProducto.DataSource = _dtMarca
                    cbxProducto.DisplayMember = "NombreActivo"
                    cbxProducto.ValueMember = "Id_Product"
                End If

            End Using
        Else
            lblPro.Visible = False
            cbxProducto.Visible = False
        End If
    End Sub

    Public Event DropDownOpened As EventHandler

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1
    Private Sub cbxProducto_DropDown(sender As Object, e As EventArgs) Handles cbxProducto.DropDown
        abierto = 0
    End Sub

    Private Sub cbxProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProducto.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxProducto_DropDownClosed(sender As Object, e As EventArgs) Handles cbxProducto.DropDownClosed
        abierto = 1
    End Sub
End Class