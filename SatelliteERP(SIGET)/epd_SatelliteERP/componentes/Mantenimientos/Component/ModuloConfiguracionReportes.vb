Public Class ModuloConfiguracionReportes
    Private objSql As New Financiero_SQLServer
    Private _tableFixedAssetsMaster As DataTable
    Private _tableGenericReport As DataTable
    Private _tableModulos As DataTable
    Property id As Integer

    Private Sub ModuloConfiguracionReportes_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetDataGenericReportModulos()
        GetDataGenericReportHeader()
        'GetClientType()
    End Sub


    Private Sub GetDataGenericReportHeader()

        _tableGenericReport = objSql.ERP_RRHH_GetGenericReportHeader()

        dgv_GenericReports.AutoGenerateColumns = False
        dgv_GenericReports.Columns(0).Width = 75
        dgv_GenericReports.Columns(1).Width = 250
        dgv_GenericReports.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_GenericReports.Columns(2).Width = 350
        dgv_GenericReports.Columns(3).Width = 100
        dgv_GenericReports.Columns(4).Width = 120
        dgv_GenericReports.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_GenericReports.Columns(5).Width = 120
        dgv_GenericReports.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_GenericReports.Columns(5).DefaultCellStyle.Format = "c"
        dgv_GenericReports.Columns(6).Width = 120
        dgv_GenericReports.ReadOnly = True
        dgv_GenericReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_GenericReports.MultiSelect = False
        dgv_GenericReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_GenericReports.AllowUserToAddRows = False
        dgv_GenericReports.AllowUserToDeleteRows = False
        dgv_GenericReports.DataSource = _tableGenericReport

    End Sub
    Private Sub GetDataGenericReportModulos()

        _tableModulos = objSql.ERP_RRHH_GetGenericReportHeaderModule()

        dtg_Modulo.AutoGenerateColumns = False
        dtg_Modulo.Columns(0).Width = 75
        dtg_Modulo.Columns(1).Width = 350
        dtg_Modulo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dtg_Modulo.Columns(2).Width = 350
        dtg_Modulo.Columns(3).Width = 180
        dtg_Modulo.Columns(4).Width = 180
        dtg_Modulo.Columns(5).Width = 180
        dtg_Modulo.ReadOnly = True
        dtg_Modulo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtg_Modulo.MultiSelect = False
        dtg_Modulo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dtg_Modulo.AllowUserToAddRows = False
        dtg_Modulo.AllowUserToDeleteRows = False
        dtg_Modulo.DataSource = _tableModulos

    End Sub

    'Private Sub GetClientType()
    '    dtDeparment = objDataTaxes.GetTipoCliente(Data_Id_Company)
    '    DG_Deparment.AutoGenerateColumns = False
    '    DG_Deparment.Columns(0).Width = 70
    '    DG_Deparment.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '    DG_Deparment.Columns(1).Width = 400
    '    DG_Deparment.Columns(2).Width = 160
    '    DG_Deparment.Columns(3).Width = 160
    '    DG_Deparment.Columns(4).Width = 160
    '    DG_Deparment.Columns(5).Width = 160
    '    DG_Deparment.ReadOnly = True
    '    DG_Deparment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    DG_Deparment.MultiSelect = False
    '    DG_Deparment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
    '    DG_Deparment.AllowUserToResizeColumns = False
    '    DG_Deparment.AllowUserToAddRows = False
    '    DG_Deparment.AllowUserToDeleteRows = False
    '    DG_Deparment.DataSource = dtDeparment
    'End Sub

    '#Region "Configuracion Fixed Asset Type Define"
    '    Private Sub GetFixedAssetTypeDefine()
    '        dtFixedAssetTypeDefine = objDataTaxes.GetFixedAssetTypeDefine()
    '        dtg_activo_fijo_define_tipo.AutoGenerateColumns = False
    '        dtg_activo_fijo_define_tipo.Columns(0).Width = 70
    '        dtg_activo_fijo_define_tipo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '        dtg_activo_fijo_define_tipo.Columns(1).Width = 260
    '        dtg_activo_fijo_define_tipo.Columns(2).Width = 257
    '        'dtg_activo_fijo_define_tipo.Columns(3).Width = 160
    '        'dtg_activo_fijo_define_tipo.Columns(4).Width = 160
    '        'dtg_activo_fijo_define_tipo.Columns(5).Width = 160
    '        dtg_activo_fijo_define_tipo.ReadOnly = True
    '        dtg_activo_fijo_define_tipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        dtg_activo_fijo_define_tipo.MultiSelect = False
    '        dtg_activo_fijo_define_tipo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
    '        dtg_activo_fijo_define_tipo.AllowUserToResizeColumns = False
    '        dtg_activo_fijo_define_tipo.AllowUserToAddRows = False
    '        dtg_activo_fijo_define_tipo.AllowUserToDeleteRows = False
    '        dtg_activo_fijo_define_tipo.DataSource = dtFixedAssetTypeDefine
    '    End Sub

    '    Private Sub btn_AgregarFixedAssetTypeDefine_Click(sender As Object, e As EventArgs)
    '        Using objManto As New Matenimiento_FixedAssetTypeDefine
    '            objManto.ID_FixedAssets_Type_Define = 0
    '            If objManto.ShowDialog() = DialogResult.OK Then
    '                GetFixedAssetTypeDefine()
    '            End If
    '        End Using
    '    End Sub

    '    Private Sub btn_ModificarFixedAssetTypeDefine_Click(sender As Object, e As EventArgs)

    '        If dtg_activo_fijo_define_tipo.CurrentRow IsNot Nothing Then
    '            Using objManto As New Matenimiento_FixedAssetTypeDefine
    '                objManto.OpcionSeleccionada = Matenimiento_FixedAssetTypeDefine.Funcion.Actualizar

    '                ' ObjUpdate.Salary = dgvemployee.CurrentRow.Cells("Salario").Value

    '                objManto.ID_FixedAssets_Type_Define = dtg_activo_fijo_define_tipo.CurrentRow.Cells(0).Value
    '                objManto.Id_FixedAssetsType = dtg_activo_fijo_define_tipo.CurrentRow.Cells(1).Value
    '                objManto.Name_Def = dtg_activo_fijo_define_tipo.CurrentRow.Cells(2).Value
    '                If objManto.ShowDialog() = DialogResult.OK Then
    '                    GetFixedAssetTypeDefine()
    '                End If

    '                GetFixedAssetTypeDefine()
    '            End Using
    '        End If
    '    End Sub

    '    Private Sub btn_EliminarFixedAssetTypeDefine_Click(sender As Object, e As EventArgs)
    '        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro"

    '        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            If objDataTaxes.DelFixedAssetTypeDefine(dtg_activo_fijo_define_tipo.CurrentRow.Cells(0).Value) = "OK" Then
    '                GetFixedAssetTypeDefine()
    '            Else
    '                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If
    '    End Sub

    '    Private Sub dtg_activo_fijo_define_tipo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    '    End Sub

    Private Sub cmdDefinirReporte_Click(sender As Object, e As EventArgs) Handles cmdDefinirReporte.Click
        Using obj As New Encabezados
            If obj.ShowDialog = DialogResult.OK Then
                GetDataGenericReportHeader()
            End If
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Using obj As New Financiero_Modulos
            If obj.ShowDialog = DialogResult.OK Then
                GetDataGenericReportModulos()
            End If
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Using obj As New Financiero_Modulos
            obj.OpcionSeleccionada = Financiero_Modulos.Funcion.Actualizar
            obj.nameModule = dtg_Modulo.CurrentRow.Cells("Name_").Value
            obj.id = dtg_Modulo.CurrentRow.Cells("id_Module").Value
            If obj.ShowDialog = DialogResult.OK Then
                GetDataGenericReportModulos()
            End If
        End Using
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If dtg_Modulo.CurrentRow IsNot Nothing Then
            Using objSql As New Generic_SQLServer
                id = dtg_Modulo.CurrentRow.Cells("id_Module").Value
                If MessageBox.Show("¿Desea eliminar el registro?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim resultado As String = objSql.DelModules(id)
                    If resultado = "OK" Then
                        MessageBox.Show("El registro ha sido eliminado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetDataGenericReportModulos()
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdModificarReporte.Click
        Using obj As New Encabezados
            obj.OpcionSeleccionada = Encabezados.Funcion.Actualizar
            obj.idHeader = dgv_GenericReports.CurrentRow.Cells("Id_Header").Value
            obj.moduloId = dgv_GenericReports.CurrentRow.Cells("id_Modulo_Fk").Value
            obj.nombre = dgv_GenericReports.CurrentRow.Cells("Name_Header").Value
            obj.descripcion = dgv_GenericReports.CurrentRow.Cells("Descrip_Header").Value
            If obj.ShowDialog = DialogResult.OK Then
                GetDataGenericReportHeader()
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdEliminarReporte.Click
        If dgv_GenericReports.CurrentRow IsNot Nothing Then
            Using objSql As New Generic_SQLServer
                id = dgv_GenericReports.CurrentRow.Cells("Id_Header").Value
                If MessageBox.Show("¿Desea eliminar el registro?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim resultado As String = objSql.ERP_RRHH_DelReportHeaders(id)
                    If resultado = "OK" Then
                        MessageBox.Show("El registro ha sido eliminado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetDataGenericReportHeader()
                    End If
                End If
            End Using
        End If
    End Sub
End Class
