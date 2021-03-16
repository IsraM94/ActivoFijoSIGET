Public Class Financiero_TablaDepreciacionPorProducto
    Property rowRegistroActual As DataRow
    Private objSqlGeneric As New Generic_SQLServer
    Private objSql As New Financiero_SQLServer
    Property vidaUtil As Integer
    Property IdFixedAsset_FK As Integer = 0
    Dim Amarillo_bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
    Dim Roja_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Roja_Bandera
    Dim Verde_Bandera As Bitmap = Global.epd_SatelliteERP.My.Resources.Resources.Verde_Bandera
    Enum TipoCalculo
        Anio = 3
        Mes = 2
        Dia = 1
    End Enum
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub Financiero_TablaDepreciacionPorProducto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As New DataTable

        dt = objSql.ERP_Finance_Get_DepreciationFixedAsset(IdFixedAsset_FK)

        DG_Depreciacion.DataSource = dt
        Try
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item(0) = i + 1
            Next
        Catch ex As Exception

        End Try

        Try
            For Each item As DataGridViewRow In DG_Depreciacion.Rows
                If (item.Cells("isaproved").Value = 1) Then
                    item.Cells("Imagen").Value = Roja_Bandera
                Else
                    item.Cells("Imagen").Value = Verde_Bandera
                End If
                If (item.Cells("FechaDepreciacion").Value = Date.Now.Date) Then
                    item.Cells("Imagen").Value = Amarillo_bandera
                End If
                If (item.Cells("FechaDepreciacion").Value > Date.Now.Date) Then
                    item.Cells("Imagen").Value = Verde_Bandera
                End If
            Next
        Catch ex As Exception

        End Try
        DG_Depreciacion.AutoGenerateColumns = False
        DG_Depreciacion.Columns(0).Width = 30
        DG_Depreciacion.Columns(1).Width = 60
        DG_Depreciacion.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DG_Depreciacion.Columns(2).Width = 160
        DG_Depreciacion.Columns(3).Width = 160
        DG_Depreciacion.Columns(4).Width = 160
        DG_Depreciacion.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Depreciacion.Columns(5).Width = 160
        DG_Depreciacion.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Depreciacion.ReadOnly = True
        DG_Depreciacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Depreciacion.MultiSelect = False
        DG_Depreciacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DG_Depreciacion.AllowUserToAddRows = False
        DG_Depreciacion.AllowUserToDeleteRows = False


        Dim _dtDepreciation As DataTable = objSqlGeneric.GetDepreciation(Data_Id_Company)
        CB_Depreciation.DataSource = _dtDepreciation
        CB_Depreciation.DisplayMember = "Name_Depreciation"
        CB_Depreciation.ValueMember = "Id_Depreciation"
        CB_Depreciation.SelectedIndex = -1

        Dim _dtixedAssetsType As DataTable = objSql.GetFixedAssetsType(Data_Id_Company)
        CB_FixedAssetsType.DataSource = _dtixedAssetsType
        CB_FixedAssetsType.DisplayMember = "Name_FixedAssetsType"
        CB_FixedAssetsType.ValueMember = "Id_FixedAssetsType"
        CB_FixedAssetsType.SelectedIndex = -1

        If Not rowRegistroActual Is Nothing Then
            txtNumeroActivoFijo.Text = rowRegistroActual.Item(0).ToString
            txtNameActive.Text = rowRegistroActual.Item("Name_FiexdAssets").ToString
            DTP_DateFactura.Value = rowRegistroActual.Item("Date_Acquisition").ToString
            CB_FixedAssetsType.SelectedValue = rowRegistroActual.Item("Id_FixedAssetsType").ToString
            CB_Depreciation.SelectedValue = rowRegistroActual.Item("Id_Depreciation_FK").ToString
            txtValorResidual.Text = rowRegistroActual.Item("ResidualValue").ToString

            vidaUtil = rowRegistroActual.Item("ResidualValue")

            lblFechaDepreciacion.Text = rowRegistroActual.Item("balancebookdate").ToString
            Try
                txtBalance.Text = rowRegistroActual.Item("balancelibro").ToString
            Catch ex As Exception
                Try
                    txtBalance.Text = rowRegistroActual.Item("balancebooks").ToString
                Catch ex2 As Exception

                End Try
            End Try
            Try
                txtValorFactura.Text = rowRegistroActual.Item("Amount_Acquired").ToString
            Catch ex As Exception
                txtValorFactura.Text = ""
            End Try


        End If
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

    Private objGeneric As New Generic_SQLServer
    Dim _DT_DataReporte As New DataTable
    Private Sub cmdPrinReport_Click(sender As Object, e As EventArgs) Handles cmdPrinReport.Click

        _DT_DataReporte = objSql.ERP_Finance_Get_DepreciationFixedAssetIndividual(IdFixedAsset_FK)

        _MostrarFiltro = True
        _FiltradoPor = "."
        If _DT_DataReporte.Rows.Count > 0 Then
            Using ObjReport As New Financiero_ReportViewer(_DT_DataReporte, "Detalle", "epd_SatelliteERP.Reporte_Inventario_Depreciacion.rdlc")
                ObjReport.StartPosition = FormStartPosition.CenterScreen
                ObjReport.ShowDialog()
            End Using
        Else
            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DG_Depreciacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Depreciacion.CellContentClick

    End Sub
#End Region

End Class