Imports System.IO

Public Class ERP_ReportAmortizacion
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private objSql As New Financiero_SQLServer
    Private Reporte As String = ""
    Private Filtro As String = ""
    Private Id_Header As Integer = 0
    Private _dtixedAssetsType_sub As DataTable
    Dim StatusDepre As Integer = 0
    Private Sub cb_Reporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Reporte.SelectedIndexChanged
        cbStatus.Enabled = False
        If (cb_Reporte.SelectedItem = "Status Depreciacion Activo Fijo") Then
            cbStatus.Enabled = True
            cbStatus.SelectedIndex = 0
        End If

    End Sub

    Private Function ModificarControles(ByVal Bandera As Boolean)
        Dim Ctl As Control
        Dim x As Integer
        For x = gbFiltros.Controls.Count - 1 To 0 Step -1
            Ctl = gbFiltros.Controls.Item(x)
            Ctl.Enabled = Bandera
        Next
    End Function



    Private Sub ERP_ReportTrasnfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListadoDepreciacion("Tod")
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim estado As Boolean = False
        estado = chkTangible.Checked
        Dim dt As New DataTable

        Using obj As New Generic_SQLServer
            dt = obj.ERP_FixedAssets_SP_GetTypeTangible(_ID_Company, estado)
        End Using
        cmdClasificacion.DataSource = dt
        cmdClasificacion.ValueMember = "Id_FixedAssetsType"
        cmdClasificacion.DisplayMember = "Name_FixedAssetsType"
        cmdClasificacion.SelectedIndex = -1
    End Sub


    Private Sub ListadoDepreciacion(ByVal Tipo As String)
        Dim dsData As New DataTable
        dsData = objSql.GetFinance_HeaderDepreciation(_ID_Company, "")
        If dsData.Rows.Count > 0 Then
            dgHeader.DataSource = dsData
            Try
                dsData.Columns.RemoveAt(3)
                dsData.Columns.RemoveAt(3)
                dsData.Columns.RemoveAt(3)
                dsData.Columns.RemoveAt(3)
            Catch ex As Exception

            End Try
            dgHeader.AutoGenerateColumns = False
            dgHeader.Columns(0).Width = 25
            dgHeader.Columns(1).Width = 200
            dgHeader.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgHeader.Columns(2).Width = 350

            dgHeader.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgHeader.MultiSelect = False
            dgHeader.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            dgHeader.AllowUserToAddRows = False
            dgHeader.AllowUserToDeleteRows = False

            Try
                'If Tipo = "Pend" Then
                '    For Each item As DataGridViewRow In DGDepreciacion.Rows
                '        item.Cells("ImagenD").Value = Amarillo_bandera
                '    Next
                'ElseIf Tipo = "Tod" Then
                '    For Each item As DataGridViewRow In DGDepreciacion.Rows
                '        If (item.Cells("statusApro").Value = 1) Then
                '            item.Cells("ImagenD").Value = Amarillo_bandera
                '        ElseIf (item.Cells("statusApro").Value = 2) Then
                '            item.Cells("ImagenD").Value = Verde_Bandera
                '        Else
                '            item.Cells("ImagenD").Value = Roja_Bandera
                '        End If
                '    Next
                'End If
            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If (cbStatus.SelectedItem = "Depreciado") Then
            StatusDepre = 1
        ElseIf cbStatus.SelectedItem = "No Depreciado" Then
            StatusDepre = 0
        Else
            StatusDepre = -1
        End If

        Dim _DT_DataReporte As New DataTable
        Dim dt As New DataTable
        Dim objSQL As New Generic_SQLServer

        Filtro = cmdClasificacion.SelectedText
        _FiltradoPor = cmdClasificacion.Text
        Dim clasificacion As Long
        Try
            clasificacion = cmdClasificacion.SelectedValue
        Catch ex As Exception
            clasificacion = 0
        End Try
        Select Case cb_Reporte.SelectedIndex
            Case 0
                _DT_DataReporte = objSQL.ERP_GetReportDepreciationFixedAsset(_ID_Company, StatusDepre, clasificacion, 1)
                _FiltradoPor = "Clasificación: " & cmdClasificacion.Text
                If (chkTangible.Checked) Then
                    _FiltradoPor &= " , TANGIBLES"
                End If
                If (StatusDepre = 0) Then
                    _FiltradoPor &= "  , ACTIVO  " & cbStatus.SelectedItem.ToString.ToUpper
                Else
                    _FiltradoPor &= "  , ACTIVO " & cbStatus.SelectedItem.ToString.ToUpper
                End If

                _MostrarFiltro = True
                If _DT_DataReporte.Rows.Count > 0 Then
                    Using ObjReport As New Financiero_ReportViewer(_DT_DataReporte, "depreciationStatus", "epd_SatelliteERP.Reporte_FixedAssets_DepreciationStatus.rdlc")
                        ObjReport.StartPosition = FormStartPosition.CenterScreen
                        ObjReport.ShowDialog()
                    End Using
                Else
                    MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case 1
                Try
                    Id_Header = dgHeader.SelectedRows(0).Cells("id_headerFK").Value
                    _FiltradoPor = "Detalle de la Depreciación: " & dgHeader.SelectedRows(0).Cells("DescriptionBD").Value
                Catch ex As Exception
                    Id_Header = 0
                End Try
                If Id_Header <= 0 Then
                    MessageBox.Show("Debe seleccionar un encabezado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    _DT_DataReporte = objSQL.ERP_GetReportDepreciationFixedAssetHeader(_ID_Company, Id_Header, clasificacion)
                    If (cmdClasificacion.Text <> "") Then
                        _FiltradoPor &= "   , Clasificación: " & cmdClasificacion.Text
                    End If

                    If (chkTangible.Checked) Then
                        _FiltradoPor &= " , TANGIBLES"
                    End If
                    _MostrarFiltro = True
                    If _DT_DataReporte.Rows.Count > 0 Then
                        Using ObjReport As New Financiero_ReportViewer(_DT_DataReporte, "depreciationbyheader", "epd_SatelliteERP.Reporte_FixedAssets_Depreciation.rdlc")
                            ObjReport.StartPosition = FormStartPosition.CenterScreen
                            ObjReport.ShowDialog()
                        End Using
                    Else
                        MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If

            Case 2

                Dim IdHeader As Long = dgHeader.CurrentRow.Cells(0).Value
                _DT_DataReporte = objSQL.ERP_GetReportDepreciationHeader(_ID_Company, clasificacion, IdHeader)
                _FiltradoPor = " "
                If (cmdClasificacion.Text <> "") Then
                    _FiltradoPor = "Clasificación:" & cmdClasificacion.Text
                End If
                If (chkTangible.Checked) Then
                    _FiltradoPor &= " , TANGIBLES"
                End If
                _MostrarFiltro = True
                If _DT_DataReporte.Rows.Count > 0 Then
                    Using ObjReport As New Financiero_ReportViewer(_DT_DataReporte, "Reportcountheader", "epd_SatelliteERP.Reporte_FixedAssets_DepreciationHeader.rdlc")
                        ObjReport.StartPosition = FormStartPosition.CenterScreen
                        ObjReport.ShowDialog()
                    End Using
                Else
                    MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Case Else
                MessageBox.Show("Seleccione un tipo de reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cb_Reporte.Focus()
        End Select
        _FiltradoPor = ""
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
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

    Private Sub chkTangible_CheckedChanged(sender As Object, e As EventArgs) Handles chkTangible.CheckedChanged
        LoadData()
    End Sub






#End Region

End Class