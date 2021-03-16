Public Class ModuloMantenimientos
    Private objDataTaxes As New Generic_SQLServer
    Private dtTaxes As DataTable
    Private dtDeparment As DataTable
    Private dtCollectingAgency As DataTable
    Private dtMunicipality As DataTable
    Private dtCountry As DataTable
    Private dtUnitMeasure As DataTable
    Private dtFixedAssetTypeDefine As DataTable

    Private objSql As New Financiero_SQLServer
    Private _tableTipoActivo As DataTable
    Private _tableEstadoTipoActivo As DataTable
    Private _tableSubTipoActivo As DataTable
    Private MOstrarlog As Boolean = True
    Private objSql2 As New Generic_SQLServer


    Private Sub ModuloMantenimientos_Load(sender As Object, e As EventArgs) Handles Me.Load

        GetDatCollectingAgency()
        ' GetDataBank()

        GetDataIndicators()

        'GetClientType()
        MOstrarlog = False
        tabMantenimientos.TabPages.Remove(TabPageTaxes)

        tabMantenimientos.TabPages.Remove(TabPageMunicipality)
        tabMantenimientos.TabPages.Remove(TabPageDepartment)
        tabMantenimientos.TabPages.Remove(TabPageCountry)
        tabMantenimientos.TabPages.Remove(TabPageUnitMeasure)

        tabMantenimientos.TabPages.Remove(TagPageCategoryMaintenance)
        tabMantenimientos.TabPages.Remove(TabPageOptionMaintenance)
        tabMantenimientos.TabPages.Remove(TabPageGeneralParameters)
        tabMantenimientos.TabPages.Remove(TabPage1)

        tabMantenimientos.TabPages.Remove(TabPage1)
        tabMantenimientos.TabPages.Remove(TabPage2)
        tabMantenimientos.TabPages.Remove(TabPage3)
        tabMantenimientos.TabPages.Remove(TabPageFixedAssetsSubTypes)
        tabMantenimientos.TabPages.Remove(ShowLog)

        Dim OpcionesMenu As DataTable = objSql2.GetAccessMenu(_UserSQL)
        If (OpcionesMenu.Rows.Count > 0) Then
            For Each DataInfo As DataRow In OpcionesMenu.Rows

                If (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_Departamentos".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageDepartment)
                    GetDataDeparment()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_Municipios".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageMunicipality)
                    GetDataMunicipality()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_Pais".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageCountry)
                    GetDatadtCountry()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_UNidadMedida".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageUnitMeasure)
                    GetDatadtUnitMeasure()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_CategoriasMantenimiento".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TagPageCategoryMaintenance)
                    GetDataCategoryMaintenance()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_OpcionesMantenimiento".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageOptionMaintenance)
                    GetDataOptionMaintenance()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVerParametrosGenerales".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageGeneralParameters)
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_ActivoFijoDefinicionTipo".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPage1)
                    GetFixedAssetTypeDefine()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_TipoActivo".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPage3)
                    GetDataTipoActivo()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_SubTipoActivo".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPageFixedAssetsSubTypes)
                    GetDataSubTipoActivo()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_EstadoTipoActivo".ToUpper) Then
                    tabMantenimientos.TabPages.Add(TabPage2)
                    GetEstadoTipoActivo()
                ElseIf (DataInfo("rolUser").ToString.ToUpper = "MN_Conf_MenuVer_VisorLog".ToUpper) Then
                    tabMantenimientos.TabPages.Add(ShowLog)
                End If
            Next
        End If


        MOstrarlog = True
    End Sub
    Private Sub GetDataTipoActivo()
        _tableTipoActivo = objSql.GetFixedAssetsType(Data_Id_Company)
        dgv_TipoActivo.AutoGenerateColumns = False
        dgv_TipoActivo.Font = New Font("Segoe UI", 11)
        dgv_TipoActivo.Columns(0).Width = 87
        dgv_TipoActivo.Columns(1).Width = 80
        dgv_TipoActivo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_TipoActivo.Columns(2).Width = 280
        dgv_TipoActivo.Columns(3).Width = 400
        dgv_TipoActivo.Columns(4).Width = 100
        'dgv_TipoActivo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_TipoActivo.Columns(5).Width = 120
        dgv_TipoActivo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_TipoActivo.Columns(5).DefaultCellStyle.Format = "c"
        dgv_TipoActivo.Columns(6).Width = 180
        dgv_TipoActivo.Columns(7).Width = 200
        dgv_TipoActivo.Columns(8).Width = 200
        dgv_TipoActivo.Columns(9).Width = 200
        dgv_TipoActivo.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_TipoActivo.ReadOnly = True
        dgv_TipoActivo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_TipoActivo.MultiSelect = False
        'dgv_TipoActivo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_TipoActivo.AllowUserToAddRows = False
        dgv_TipoActivo.AllowUserToDeleteRows = False
        dgv_TipoActivo.DataSource = _tableTipoActivo

    End Sub
    Private Sub GetEstadoTipoActivo()
        _tableEstadoTipoActivo = objSql.ERP_getFixedAssets_State()
        dtg_estado_tipo_Activo.AutoGenerateColumns = False
        dtg_estado_tipo_Activo.Font = New Font("Segoe UI", 11)
        dtg_estado_tipo_Activo.Columns(0).Width = 87
        dtg_estado_tipo_Activo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_estado_tipo_Activo.Columns(1).Width = 150

        dtg_estado_tipo_Activo.Columns(2).Width = 300
        dtg_estado_tipo_Activo.Columns(3).Width = 100
        dtg_estado_tipo_Activo.Columns(4).Width = 180
        dtg_estado_tipo_Activo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_estado_tipo_Activo.Columns(5).Width = 120
        'dtg_estado_tipo_Activo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_estado_tipo_Activo.Columns(5).DefaultCellStyle.Format = "c"
        dtg_estado_tipo_Activo.Columns(6).Width = 180
        dtg_estado_tipo_Activo.Columns(7).Width = 200
        dtg_estado_tipo_Activo.ReadOnly = True
        dtg_estado_tipo_Activo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtg_estado_tipo_Activo.MultiSelect = False
        dtg_estado_tipo_Activo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dtg_estado_tipo_Activo.AllowUserToAddRows = False
        dtg_estado_tipo_Activo.AllowUserToDeleteRows = False
        dtg_estado_tipo_Activo.DataSource = _tableEstadoTipoActivo

    End Sub
#Region "Configuracion Taxes"

    Private Sub GetDataTax()
        dtTaxes = objDataTaxes.GetTaxes(Data_Id_Company)
        DG_Taxes.AutoGenerateColumns = False
        DG_Taxes.Font = New Font("Segoe UI", 11)
        DG_Taxes.Columns(0).Width = 85
        DG_Taxes.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Taxes.Columns(1).Width = 260
        DG_Taxes.Columns(2).Width = 257
        DG_Taxes.Columns(6).Width = 100
        DG_Taxes.Columns(7).Width = 120
        DG_Taxes.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Taxes.Columns(7).DefaultCellStyle.Format = "N4"
        DG_Taxes.ReadOnly = True
        DG_Taxes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Taxes.MultiSelect = False
        DG_Taxes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_Taxes.AllowUserToResizeColumns = False
        DG_Taxes.AllowUserToAddRows = False
        DG_Taxes.AllowUserToDeleteRows = False
        DG_Taxes.DataSource = dtTaxes
    End Sub

    Private Sub cmdCreate_Tax_Click(sender As Object, e As EventArgs) Handles cmdCreate_Tax.Click
        Using objManGTaxes As New Mantenimiento_Generic_Taxes
            ''objManGTaxes.Id_Country = 0
            If objManGTaxes.ShowDialog() = DialogResult.OK Then
                GetDataTax()
            End If
        End Using


    End Sub


    Private Sub cmdModify_Tax_Click(sender As Object, e As EventArgs) Handles cmdModify_Tax.Click
        Using objManGTaxes As New Mantenimiento_Generic_Taxes
            objManGTaxes.Id_Tax = DG_Taxes.CurrentRow.Cells(0).Value
            objManGTaxes.Id_Company_FK = DG_Taxes.CurrentRow.Cells(8).Value
            objManGTaxes.Id_CollectingAgency_FK = DG_Taxes.CurrentRow.Cells(9).Value
            objManGTaxes.Name_Tax = DG_Taxes.CurrentRow.Cells(2).Value
            objManGTaxes.Name_CollectingAgency = DG_Taxes.CurrentRow.Cells(1).Value
            objManGTaxes.Is_TaxParent = DG_Taxes.CurrentRow.Cells(3).Value
            objManGTaxes.Is_TaxLine = DG_Taxes.CurrentRow.Cells(4).Value
            objManGTaxes.Is_TaxProduct = DG_Taxes.CurrentRow.Cells(5).Value
            objManGTaxes.IsPercent = DG_Taxes.CurrentRow.Cells(6).Value
            objManGTaxes.Value = DG_Taxes.CurrentRow.Cells(7).Value

            If objManGTaxes.ShowDialog() = DialogResult.OK Then
                GetDataTax()
            End If
        End Using
    End Sub

    Private Sub cmdDelete_Tax_Click(sender As Object, e As EventArgs) Handles cmdDelete_Tax.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                                "Nombre : " & DG_Taxes.CurrentRow.Cells(2).Value & vbCrLf &
                                "valor : " & DG_Taxes.CurrentRow.Cells(7).Value
        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelTaxes(DG_Taxes.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then

                GetDataTax()

            End If
        End If


    End Sub
    Private Sub cmdCreate_Deparment_Click(sender As Object, e As EventArgs) Handles cmdCreate_Deparment.Click
        Using objManto As New Mantenimiento_Departamentos
            objManto.Id_Departament = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataDeparment()
            End If
        End Using
    End Sub
    Private Sub cmdModify_Deparment_Click(sender As Object, e As EventArgs) Handles cmdModify_Deparment.Click
        Using objManto As New Mantenimiento_Departamentos
            objManto.Id_Departament = DG_Deparment.CurrentRow.Cells(0).Value
            objManto.Name_Departament = DG_Deparment.CurrentRow.Cells(1).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataDeparment()
            End If
        End Using
    End Sub
    Private Sub cmdDelete_Deparment_Click(sender As Object, e As EventArgs) Handles cmdDelete_Deparment.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                          "Nombre : " & DG_Deparment.CurrentRow.Cells(1).Value & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelDeparment(DG_Deparment.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetDataDeparment()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region
#Region "Configuracion Agencia Recolectora"
    Private Sub GetDatCollectingAgency()
        'dtCollectingAgency = objDataTaxes.GetCollectingAgency(Data_Id_Company)
        'DG_CollectingAgency.AutoGenerateColumns = False
        'DG_CollectingAgency.Columns(0).Width = 70
        'DG_CollectingAgency.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DG_CollectingAgency.Columns(1).Width = 400
        'DG_CollectingAgency.Columns(2).Width = 160
        'DG_CollectingAgency.Columns(3).Width = 160
        'DG_CollectingAgency.Columns(4).Width = 160
        'DG_CollectingAgency.Columns(5).Width = 160
        'DG_CollectingAgency.ReadOnly = True
        'DG_CollectingAgency.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DG_CollectingAgency.MultiSelect = False
        'DG_CollectingAgency.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_CollectingAgency.AllowUserToResizeColumns = False
        'DG_CollectingAgency.AllowUserToAddRows = False
        'DG_CollectingAgency.AllowUserToDeleteRows = False
        'DG_CollectingAgency.DataSource = dtCollectingAgency
    End Sub

    Private Sub cmdCreate_CollectingAgency_Click(sender As Object, e As EventArgs)
        Using objManto As New Mantenimiento_Generic_CollectingAgency
            objManto.Id_CollectingAgency = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDatCollectingAgency()
            End If
        End Using
    End Sub

    Private Sub cmdModify_CollectingAgency_Click(sender As Object, e As EventArgs)
        'Using objManto As New Mantenimiento_Generic_CollectingAgency
        '    objManto.Id_CollectingAgency = DG_CollectingAgency.CurrentRow.Cells(0).Value
        '    objManto.Name_CollectingAgency = DG_CollectingAgency.CurrentRow.Cells(1).Value
        '    If objManto.ShowDialog() = DialogResult.OK Then
        '        GetDatCollectingAgency()
        '    End If
        'End Using
    End Sub
    Private Sub cmdDel_CollectingAgency_Click(sender As Object, e As EventArgs)
        'Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
        '                 "Nombre : " & DG_CollectingAgency.CurrentRow.Cells(1).Value & vbCrLf

        'If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    If objDataTaxes.DelCollectingAgency(DG_CollectingAgency.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
        '        GetDatCollectingAgency()
        '    Else
        '        MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If
    End Sub
#End Region
#Region "Configurar Municipality"
    Private Sub GetDataMunicipality()
        dtMunicipality = objDataTaxes.GetMunicipality(Data_Id_Company)
        DG_Municipality.AutoGenerateColumns = False
        DG_Municipality.Font = New Font("Segoe UI", 11)
        DG_Municipality.Columns(0).Width = 87
        DG_Municipality.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Municipality.Columns(1).Width = 260
        DG_Municipality.Columns(2).Width = 257
        DG_Municipality.Columns(3).Width = 160
        DG_Municipality.Columns(4).Width = 180
        DG_Municipality.Columns(5).Width = 160
        DG_Municipality.Columns(6).Width = 180
        DG_Municipality.ReadOnly = True
        DG_Municipality.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Municipality.MultiSelect = False
        DG_Municipality.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_Municipality.AllowUserToResizeColumns = False
        DG_Municipality.AllowUserToAddRows = False
        DG_Municipality.AllowUserToDeleteRows = False
        DG_Municipality.DataSource = dtMunicipality
    End Sub
    Private Sub cmdCreate_Municipality_Click(sender As Object, e As EventArgs) Handles cmdCreate_Municipality.Click
        Using objManto As New Mantenimiento_Generic_Municipality
            objManto.Id_Municipality = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataMunicipality()
            End If
        End Using
    End Sub
    Private Sub cmdModify_Municipality_Click(sender As Object, e As EventArgs) Handles cmdModify_Municipality.Click
        Using objManto As New Mantenimiento_Generic_Municipality
            objManto.Id_Municipality = DG_Municipality.CurrentRow.Cells(0).Value
            objManto.Name_Municipality = DG_Municipality.CurrentRow.Cells(2).Value
            objManto.Name_Deparment = DG_Municipality.CurrentRow.Cells(1).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataMunicipality()
            End If
        End Using
    End Sub
    Private Sub cmdDel_Municipality_Click(sender As Object, e As EventArgs) Handles cmdDel_Municipality.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                        "Nombre : " & DG_Municipality.CurrentRow.Cells(2).Value & vbCrLf &
                        "Departamento : " & DG_Municipality.CurrentRow.Cells(1).Value & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelMunicipality(DG_Municipality.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetDataMunicipality()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region
#Region "Configurar Country"
    Private Sub GetDatadtCountry()
        dtCountry = objDataTaxes.GetCountry(Data_Id_Company)
        DG_Country.AutoGenerateColumns = False
        DG_Country.Font = New Font("Segoe UI", 11)
        DG_Country.Columns(0).Width = 87
        DG_Country.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Country.Columns(1).Width = 260
        DG_Country.Columns(2).Width = 160
        DG_Country.Columns(3).Width = 180
        DG_Country.Columns(4).Width = 160
        DG_Country.Columns(5).Width = 180

        DG_Country.ReadOnly = True
        DG_Country.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Country.MultiSelect = False
        DG_Country.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_Country.AllowUserToResizeColumns = False
        DG_Country.AllowUserToAddRows = False
        DG_Country.AllowUserToDeleteRows = False
        DG_Country.DataSource = dtCountry
    End Sub
    Private Sub cmdCreate_Country_Click(sender As Object, e As EventArgs) Handles cmdCreate_Country.Click
        Using objManto As New Mantenimiento_Generic_Country
            objManto.Id_Country = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDatadtCountry()
            End If
        End Using
    End Sub
    Private Sub cmdModify_Country_Click(sender As Object, e As EventArgs) Handles cmdModify_Country.Click
        Using objManto As New Mantenimiento_Generic_Country
            objManto.Id_Country = DG_Country.CurrentRow.Cells(0).Value
            objManto.Name_Country = DG_Country.CurrentRow.Cells(1).Value
            objManto.ShortName = DG_Country.CurrentRow.Cells(2).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDatadtCountry()
            End If
        End Using
    End Sub
    Private Sub cmdDelete_Contry_Click(sender As Object, e As EventArgs) Handles cmdDelete_Contry.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                      "Pais : " & DG_Country.CurrentRow.Cells(1).Value & vbCrLf &
                      "Nombre Corto : " & DG_Country.CurrentRow.Cells(2).Value & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelCountry(DG_Country.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetDatadtCountry()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region
#Region "Configurar UnitMeasure"
    Private Sub GetDatadtUnitMeasure()
        dtUnitMeasure = objDataTaxes.GetUnitMeasure(Data_Id_Company)
        DG_UnitMeasure.AutoGenerateColumns = False
        DG_UnitMeasure.Font = New Font("Segoe UI", 11)
        DG_UnitMeasure.Columns(0).Width = 87
        DG_UnitMeasure.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_UnitMeasure.Columns(1).Width = 260
        DG_UnitMeasure.Columns(2).Width = 160
        DG_UnitMeasure.Columns(2).DefaultCellStyle.Format = "N4"
        DG_UnitMeasure.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_UnitMeasure.Columns(3).Width = 160
        DG_UnitMeasure.Columns(4).Width = 185
        DG_UnitMeasure.Columns(5).Width = 160
        DG_UnitMeasure.Columns(6).Width = 185
        DG_UnitMeasure.ReadOnly = True
        DG_UnitMeasure.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_UnitMeasure.MultiSelect = False
        DG_UnitMeasure.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_UnitMeasure.AllowUserToResizeColumns = False
        DG_UnitMeasure.AllowUserToAddRows = False
        DG_UnitMeasure.AllowUserToDeleteRows = False
        DG_UnitMeasure.DataSource = dtUnitMeasure
    End Sub
    Private Sub cmdCreate_UnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdCreate_UnitMeasure.Click
        Using objManto As New Mantenimiento_Generic_UnitMeasure
            objManto.Id_UnitMeasure = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDatadtUnitMeasure()
            End If
        End Using
    End Sub
    Private Sub cmdModify_UnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdModify_UnitMeasure.Click
        Using objManto As New Mantenimiento_Generic_UnitMeasure
            objManto.Id_UnitMeasure = DG_UnitMeasure.CurrentRow.Cells(0).Value
            objManto.Name_UnitMeasure = DG_UnitMeasure.CurrentRow.Cells(1).Value
            objManto.Unit_Conversion = DG_UnitMeasure.CurrentRow.Cells(2).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDatadtUnitMeasure()
            End If
        End Using
    End Sub
    Private Sub cmdDelete_UnitMeasure_Click(sender As Object, e As EventArgs) Handles cmdDelete_UnitMeasure.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                     "Unidad de Medida : " & DG_UnitMeasure.CurrentRow.Cells(1).Value & vbCrLf &
                     "Valor : " & DG_UnitMeasure.CurrentRow.Cells(2).Value & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelUnitMeasure(DG_UnitMeasure.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetDatadtUnitMeasure()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region

#Region "Configurar Bank"
    Private Sub GetDataBank()
        dtMunicipality = objDataTaxes.GetBank(Data_Id_Company)
        'DG_Bank.AutoGenerateColumns = False
        'DG_Bank.Columns(0).Width = 70
        'DG_Bank.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DG_Bank.Columns(1).Width = 260
        'DG_Bank.Columns(2).Width = 257
        'DG_Bank.Columns(3).Width = 160
        'DG_Bank.Columns(4).Width = 160
        'DG_Bank.Columns(5).Width = 160
        'DG_Bank.ReadOnly = True
        'DG_Bank.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'DG_Bank.MultiSelect = False
        'DG_Bank.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_Bank.AllowUserToResizeColumns = False
        'DG_Bank.AllowUserToAddRows = False
        'DG_Bank.AllowUserToDeleteRows = False
        'DG_Bank.DataSource = dtMunicipality
    End Sub
    Private Sub cmdCreate_Bank_Click(sender As Object, e As EventArgs)
        Using objManto As New Mantenimiento_Generic_Bank
            objManto.Id_Bank = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataBank()
            End If
        End Using
    End Sub
    Private Sub cmdModify_Bank_Click(sender As Object, e As EventArgs)
        'Using objManto As New Mantenimiento_Generic_Bank
        '    objManto.Id_Bank = DG_Bank.CurrentRow.Cells(0).Value
        '    objManto.Name_Bank = DG_Bank.CurrentRow.Cells(1).Value
        '    If objManto.ShowDialog() = DialogResult.OK Then
        '        GetDataBank()
        '    End If
        'End Using
    End Sub
    Private Sub cmdDel_Bank_Click(sender As Object, e As EventArgs)
        'Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
        '                "Nombre : " & DG_Bank.CurrentRow.Cells(1).Value & vbCrLf

        'If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    If objDataTaxes.DelBank(DG_Bank.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
        '        GetDataBank()
        '    Else
        '        MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If
    End Sub
#End Region

#Region "Configurar Category Maintenance"
    Private Sub GetDataCategoryMaintenance()
        dtMunicipality = objDataTaxes.GetCategoryMaintenance(Data_Id_Company)
        DG_CategoryMaintenance.AutoGenerateColumns = False
        DG_CategoryMaintenance.Font = New Font("Segoe UI", 11)
        DG_CategoryMaintenance.Columns(0).Width = 87
        DG_CategoryMaintenance.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_CategoryMaintenance.Columns(1).Width = 260
        DG_CategoryMaintenance.Columns(2).Width = 257
        DG_CategoryMaintenance.Columns(3).Width = 180
        DG_CategoryMaintenance.Columns(4).Width = 180
        DG_CategoryMaintenance.Columns(5).Width = 180

        DG_CategoryMaintenance.ReadOnly = True
        DG_CategoryMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_CategoryMaintenance.MultiSelect = False
        DG_CategoryMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_CategoryMaintenance.AllowUserToResizeColumns = False
        DG_CategoryMaintenance.AllowUserToAddRows = False
        DG_CategoryMaintenance.AllowUserToDeleteRows = False
        DG_CategoryMaintenance.DataSource = dtMunicipality
    End Sub
    Private Sub cmdCreate_CategoryMaintenance_Click(sender As Object, e As EventArgs) Handles cmdCreate_CategoryMaintenance.Click
        Using objManto As New Mantenimiento_Generic_CategoryMaintenance
            objManto.Id_CategoryMaintenance = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataCategoryMaintenance()
            End If
        End Using
    End Sub
    Private Sub cmdModify_CategoryMaintenance_Click(sender As Object, e As EventArgs) Handles cmdModify_CategoryMaintenance.Click
        Using objManto As New Mantenimiento_Generic_CategoryMaintenance
            objManto.Id_CategoryMaintenance = DG_CategoryMaintenance.CurrentRow.Cells(0).Value
            objManto.Name_CategoryMaintenance = DG_CategoryMaintenance.CurrentRow.Cells(1).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataCategoryMaintenance()
            End If
        End Using
    End Sub
    Private Sub cmdDel_CategoryMaintenance_Click(sender As Object, e As EventArgs) Handles cmdDel_CategoryMaintenance.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                        "Nombre : " & DG_CategoryMaintenance.CurrentRow.Cells(1).Value & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelCategoryMaintenance(DG_CategoryMaintenance.CurrentRow.Cells(0).Value) = "OK" Then
                GetDataCategoryMaintenance()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region

#Region "Configurar Option Maintenance"
    Private Sub GetDataOptionMaintenance()
        dtMunicipality = objDataTaxes.GetOptionMaintenance(Data_Id_Company)
        DG_OptionMaintenance.AutoGenerateColumns = False
        DG_OptionMaintenance.Font = New Font("Segoe UI", 11)
        DG_OptionMaintenance.Columns(0).Width = 87
        DG_OptionMaintenance.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_OptionMaintenance.Columns(1).Width = 260
        DG_OptionMaintenance.Columns(2).Width = 257
        DG_OptionMaintenance.Columns(3).Width = 160
        DG_OptionMaintenance.Columns(4).Width = 180
        DG_OptionMaintenance.Columns(5).Width = 160
        DG_OptionMaintenance.Columns(6).Width = 180
        DG_OptionMaintenance.ReadOnly = True
        DG_OptionMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_OptionMaintenance.MultiSelect = False
        DG_OptionMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_OptionMaintenance.AllowUserToResizeColumns = False
        DG_OptionMaintenance.AllowUserToAddRows = False
        DG_OptionMaintenance.AllowUserToDeleteRows = False
        DG_OptionMaintenance.DataSource = dtMunicipality
    End Sub
    Private Sub cmdCreate_OptionMaintenance_Click(sender As Object, e As EventArgs) Handles cmdCreate_OptionMaintenance.Click
        Using objManto As New Mantenimiento_Generic_OptionMaintenance
            objManto.Id_OptionMaintenance = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataOptionMaintenance()
            End If
        End Using
    End Sub
    Private Sub cmdModify_OptionMaintenance_Click(sender As Object, e As EventArgs) Handles cmdModify_OptionMaintenance.Click

        Using objManto As New Mantenimiento_Generic_OptionMaintenance
            objManto.Id_OptionMaintenance = DG_OptionMaintenance.CurrentRow.Cells(0).Value
            objManto.Id_Category = DG_OptionMaintenance.CurrentRow.Cells(7).Value
            objManto.Name_OptionMaintenance = DG_OptionMaintenance.CurrentRow.Cells(2).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataOptionMaintenance()
            End If
        End Using
    End Sub
    Private Sub cmdDel_OptionMaintenance_Click(sender As Object, e As EventArgs) Handles cmdDel_OptionMaintenance.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & vbCrLf &
                        "Nombre : " & DG_OptionMaintenance.CurrentRow.Cells(1).Value & vbCrLf

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelOptionMaintenance(DG_OptionMaintenance.CurrentRow.Cells(0).Value, Data_Id_Company) = "OK" Then
                GetDataOptionMaintenance()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

#End Region
#Region "DataDepartment"
    Private Sub GetDataDeparment()
        dtDeparment = objDataTaxes.GetDeparment(Data_Id_Company)
        DG_Deparment.AutoGenerateColumns = False
        DG_Deparment.Font = New Font("Segoe UI", 11)
        DG_Deparment.Columns(0).Width = 85
        DG_Deparment.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_Deparment.Columns(1).Width = 400
        DG_Deparment.Columns(2).Width = 160
        DG_Deparment.Columns(3).Width = 180
        DG_Deparment.Columns(4).Width = 160
        DG_Deparment.Columns(5).Width = 180
        DG_Deparment.ReadOnly = True
        DG_Deparment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_Deparment.MultiSelect = False
        DG_Deparment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_Deparment.AllowUserToResizeColumns = False
        DG_Deparment.AllowUserToAddRows = False
        DG_Deparment.AllowUserToDeleteRows = False
        DG_Deparment.DataSource = dtDeparment
    End Sub
#End Region

#Region "Indicadores"
    Private Sub GetDataIndicators()
        dtDeparment = objDataTaxes.ERP_Config_GetDataIndicators()
        DG_GeneralParameters.AutoGenerateColumns = False
        DG_GeneralParameters.Font = New Font("Segoe UI", 11)
        DG_GeneralParameters.Columns(0).Width = 87
        DG_GeneralParameters.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DG_GeneralParameters.Columns(1).Width = 150
        DG_GeneralParameters.Columns(2).Width = 400
        DG_GeneralParameters.Columns(3).Width = 160
        DG_GeneralParameters.Columns(4).Width = 160
        DG_GeneralParameters.ReadOnly = True
        DG_GeneralParameters.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_GeneralParameters.MultiSelect = False
        DG_GeneralParameters.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'DG_GeneralParameters.AllowUserToResizeColumns = False
        DG_GeneralParameters.AllowUserToAddRows = False
        DG_GeneralParameters.AllowUserToDeleteRows = False
        DG_GeneralParameters.DataSource = dtDeparment
    End Sub

    Private Sub cmdModify_GeneralParameter_Click(sender As Object, e As EventArgs) Handles cmdModify_GeneralParameter.Click
        Using objManto As New Mantenimiento_Indicators
            objManto.Id_Indicator = DG_GeneralParameters.CurrentRow.Cells(0).Value
            objManto.Name_Indicator = DG_GeneralParameters.CurrentRow.Cells(1).Value
            objManto.Value_Indicator = DG_GeneralParameters.CurrentRow.Cells(3).Value
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataIndicators()
            End If
        End Using
    End Sub

    Private Sub FlowLayoutPanel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

#End Region

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

#Region "Configuracion Fixed Asset Type Define"
    Private Sub GetFixedAssetTypeDefine()
        dtFixedAssetTypeDefine = objDataTaxes.GetFixedAssetTypeDefine()
        dtg_activo_fijo_define_tipo.AutoGenerateColumns = False
        dtg_activo_fijo_define_tipo.Font = New Font("Segoe UI", 11)
        dtg_activo_fijo_define_tipo.Columns(0).Width = 70
        dtg_activo_fijo_define_tipo.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dtg_activo_fijo_define_tipo.Columns(1).Width = 280
        dtg_activo_fijo_define_tipo.Columns(2).Width = 257
        dtg_activo_fijo_define_tipo.Columns(3).Width = 250

        dtg_activo_fijo_define_tipo.Columns(4).Width = 160
        dtg_activo_fijo_define_tipo.Columns(5).Width = 160
        dtg_activo_fijo_define_tipo.ReadOnly = True
        dtg_activo_fijo_define_tipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtg_activo_fijo_define_tipo.MultiSelect = False
        dtg_activo_fijo_define_tipo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dtg_activo_fijo_define_tipo.AllowUserToResizeColumns = True
        dtg_activo_fijo_define_tipo.AllowUserToAddRows = False
        dtg_activo_fijo_define_tipo.AllowUserToDeleteRows = False
        dtg_activo_fijo_define_tipo.DataSource = dtFixedAssetTypeDefine
    End Sub

    Private Sub btn_AgregarFixedAssetTypeDefine_Click_1(sender As Object, e As EventArgs) Handles btn_AgregarFixedAssetTypeDefine.Click
        Using objManto As New Matenimiento_FixedAssetTypeDefine
            objManto.ID_FixedAssets_Type_Define = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetFixedAssetTypeDefine()
            End If
        End Using
    End Sub

    Private Sub btn_ModificarFixedAssetTypeDefine_Click_1(sender As Object, e As EventArgs) Handles btn_ModificarFixedAssetTypeDefine.Click
        If dtg_activo_fijo_define_tipo.CurrentRow IsNot Nothing Then
            Using objManto As New Matenimiento_FixedAssetTypeDefine
                objManto.OpcionSeleccionada = Matenimiento_FixedAssetTypeDefine.Funcion.Actualizar

                ' ObjUpdate.Salary = dgvemployee.CurrentRow.Cells("Salario").Value

                objManto.ID_FixedAssets_Type_Define = dtg_activo_fijo_define_tipo.CurrentRow.Cells(0).Value
                objManto.Id_FixedAssetsType = dtg_activo_fijo_define_tipo.CurrentRow.Cells(1).Value
                objManto.Name_Def = dtg_activo_fijo_define_tipo.CurrentRow.Cells(2).Value
                If objManto.ShowDialog() = DialogResult.OK Then
                    GetFixedAssetTypeDefine()
                End If

                GetFixedAssetTypeDefine()
            End Using
        End If
    End Sub

    Private Sub btn_EliminarFixedAssetTypeDefine_Click_1(sender As Object, e As EventArgs) Handles btn_EliminarFixedAssetTypeDefine.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro"

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.DelFixedAssetTypeDefine(dtg_activo_fijo_define_tipo.CurrentRow.Cells(0).Value) = "OK" Then
                GetFixedAssetTypeDefine()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Using objManto As New Matenimiento_FixedAssetType

            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataTipoActivo()
            End If
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If dgv_TipoActivo.CurrentRow IsNot Nothing Then
            Using objManto As New Matenimiento_FixedAssetType
                objManto.OpcionSeleccionada = Matenimiento_FixedAssetType.Funcion.Actualizar

                ' ObjUpdate.Salary = dgvemployee.CurrentRow.Cells("Salario").Value
                objManto.id = dgv_TipoActivo.CurrentRow.Cells(0).Value
                objManto.nombreTipoActivo = dgv_TipoActivo.CurrentRow.Cells(2).Value
                objManto.descripcionTipoActivo = dgv_TipoActivo.CurrentRow.Cells(3).Value
                objManto.isTangible = dgv_TipoActivo.CurrentRow.Cells(11).Value

                objManto.AccountingAccount = dgv_TipoActivo.CurrentRow.Cells(12).Value


                Try
                    objManto.vidaUtil = dgv_TipoActivo.CurrentRow.Cells(10).Value
                Catch ex As Exception
                    objManto.vidaUtil = 0
                End Try


                If objManto.ShowDialog() = DialogResult.OK Then
                    GetDataTipoActivo()
                End If

                GetDataTipoActivo()
            End Using
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro"

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.ERP_DelFixedAssetType(dgv_TipoActivo.CurrentRow.Cells(0).Value) = "ok" Then
                GetDataTipoActivo()
            Else
                MessageBox.Show("Error en eliminacion de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using objManto As New Matenimiento_FixedAssetState

            If objManto.ShowDialog() = DialogResult.OK Then
                GetEstadoTipoActivo()
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dtg_estado_tipo_Activo.CurrentRow IsNot Nothing Then
            Using objManto As New Matenimiento_FixedAssetState

                objManto.OpcionSeleccionada = Matenimiento_FixedAssetState.Funcion.Actualizar

                objManto.id = dtg_estado_tipo_Activo.CurrentRow.Cells(0).Value.ToString
                objManto.nombre = dtg_estado_tipo_Activo.CurrentRow.Cells(1).Value.ToString
                objManto.descripcion = dtg_estado_tipo_Activo.CurrentRow.Cells(2).Value.ToString
                Try
                    objManto.Is_Low = dtg_estado_tipo_Activo.CurrentRow.Cells(8).Value.ToString
                Catch ex As Exception
                    objManto.Is_Low = False
                End Try
                If objManto.ShowDialog() = DialogResult.OK Then
                    GetEstadoTipoActivo()
                End If

            End Using
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro"

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objDataTaxes.ERP_DelFixedAssets_State(dtg_estado_tipo_Activo.CurrentRow.Cells(0).Value) = "OK" Then
                GetEstadoTipoActivo()
            Else
                MessageBox.Show("Error en eliminaciÓn de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub tabMantenimientos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMantenimientos.SelectedIndexChanged
        Try

            If sender.SelectedTab.Name = "ShowLog" And MOstrarlog Then
                Using obj As New ShowLog
                    obj.ShowDialog()
                End Using
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Sub Tipos de Activo Fijo"
    Private Sub GetDataSubTipoActivo()
        _tableSubTipoActivo = objSql.GetFixedAssetsSubType(Data_Id_Company, 0)
        dgv_SubTipoActivo.AutoGenerateColumns = False
        dgv_SubTipoActivo.Font = New Font("Segoe UI", 11)
        dgv_SubTipoActivo.Columns(0).Width = 87
        dgv_SubTipoActivo.Columns(1).Width = 80
        dgv_SubTipoActivo.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_SubTipoActivo.Columns(2).Width = 280
        dgv_SubTipoActivo.Columns(3).Width = 400
        dgv_SubTipoActivo.Columns(4).Width = 100
        'dgv_TipoActivo.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_SubTipoActivo.Columns(5).Width = 120
        dgv_SubTipoActivo.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_SubTipoActivo.Columns(5).DefaultCellStyle.Format = "c"
        dgv_SubTipoActivo.Columns(6).Width = 180
        dgv_SubTipoActivo.Columns(7).Width = 200
        dgv_SubTipoActivo.Columns(8).Width = 200
        dgv_SubTipoActivo.Columns(9).Width = 200
        dgv_SubTipoActivo.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv_SubTipoActivo.ReadOnly = True
        dgv_SubTipoActivo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_SubTipoActivo.MultiSelect = False
        'dgv_TipoActivo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv_SubTipoActivo.AllowUserToAddRows = False
        dgv_SubTipoActivo.AllowUserToDeleteRows = False
        dgv_SubTipoActivo.DataSource = _tableSubTipoActivo

    End Sub

    Private Sub btnAddFixedAssetsSubType_Click(sender As Object, e As EventArgs) Handles btnAddFixedAssetsSubType.Click
        Using objManto As New Mantenimiento_FixedAssetSubType
            objManto.Id_FixedAssetSubType = 0
            If objManto.ShowDialog() = DialogResult.OK Then
                GetDataSubTipoActivo()
            End If
        End Using
    End Sub

    Private Sub btnModifyFixedAssetsSubType_Click(sender As Object, e As EventArgs) Handles btnModifyFixedAssetsSubType.Click
        If dgv_SubTipoActivo.CurrentRow IsNot Nothing Then
            Using objManto As New Mantenimiento_FixedAssetSubType
                ' ObjUpdate.Salary = dgvemployee.CurrentRow.Cells("Salario").Value

                objManto.Id_FixedAssetSubType = dgv_SubTipoActivo.CurrentRow.Cells(0).Value
                objManto.FixedAssetType = dgv_SubTipoActivo.CurrentRow.Cells(2).Value
                objManto.Name_FixedAssetSubType = dgv_SubTipoActivo.CurrentRow.Cells(3).Value
                Try
                    objManto.Description_FixedAssetSubType = dgv_SubTipoActivo.CurrentRow.Cells(4).Value
                Catch ex As Exception
                    objManto.Description_FixedAssetSubType =""
                End Try
                Try
                    objManto.Is_Tangible = dgv_SubTipoActivo.CurrentRow.Cells(5).Value
                Catch ex As Exception
                    objManto.Is_Tangible = False
                End Try

                If objManto.ShowDialog() = DialogResult.OK Then
                    GetDataSubTipoActivo()
                End If
            End Using
        End If
    End Sub

    Private Sub btnDeleteFixedAssetsSubType_Click(sender As Object, e As EventArgs) Handles btnDeleteFixedAssetsSubType.Click
        Dim mensaje As String = "Esta seguro(a) que quiere eliminar el siguiente registro: " & dgv_SubTipoActivo.CurrentRow.Cells("Name_FixedAssetsSubType").Value

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objSql.DeleteFixedAssetsSubTypes(Data_Id_Company, dgv_SubTipoActivo.CurrentRow.Cells(0).Value) = "OK" Then
                GetDataSubTipoActivo()
            Else
                MessageBox.Show("Error en eliminación de registro.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


#End Region

End Class
