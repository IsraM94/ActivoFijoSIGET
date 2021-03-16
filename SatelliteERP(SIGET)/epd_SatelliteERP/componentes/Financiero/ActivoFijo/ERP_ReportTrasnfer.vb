Imports System.IO

Public Class ERP_ReportTrasnfer
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private objSql As New Financiero_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private Reporte As String = ""
    Private Codigo As String = ""
    Private NombreActivo As String = ""
    Private Id_Clasificacion As String = ""
    Private Id_Sub_Clasificacion As String = ""
    Private Id_estado_Fk As Integer = 0
    Private RangoFechaAdquisicion As String = ""
    Private FechaAdquisicionInicial As Date = Date.Now
    Private FechaAdquisicionFinal As Date = Date.Now
    Private RangoVidaUtil As String = ""
    Private VidaUtilInicial As Integer = 0
    Private VidaUtilFinal As Integer = 0
    Private RangoValorAdquisicionInicial As Double = 0
    Private RangoValorAdquisicionFinal As Double = 0
    Private ValorAdquisicionInicial As Double
    Private ValorAdquisicionFinal As Double
    Private FechaDescargoInicial As Date
    Private FechaDescargoFinal As Date
    Private Ubicacion As Integer = 0
    Private RangoValorAdquisicion As String = ""
    Private Filtro As String = ""
    Private Id_Employee As Integer = 0
    Private UbicacionPrimaria As String = ""
    Private UbicacionSecundaria As String = ""
    Private UnidadOrganizativa As String = ""
    Private _dtixedAssetsType_sub As DataTable
    Private IdReporte = 0
    Private FechasAct As Boolean = False
    Private Fecha_Ad_Act As Boolean = False
    Private Valor_Ad_Act As Boolean = False
    Private OrdenadoPor As String = ""
    Property _Asistente As Boolean = True
    Private folder As String = ""
    Dim dt As New DataTable
    Private Sub cb_Reporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ReporteTransferencia.SelectedIndexChanged
        'ModificarControles(True)
        'dtpFechaDesde.Enabled = False
        'dtpFechaHasta.Enabled = False
        'chkFechas.Checked = False
        If (cb_ReporteTransferencia.SelectedItem = "Fecha de Transferencias Activo Fijo") Then
            IdReporte = 0
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Por Estado de Activo Fijo") Then
            IdReporte = 1
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Ficha Institucional Activo Fijo") Then
            IdReporte = 2
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Ficha Clasificacion Activo Fijo") Then
            IdReporte = 3
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Ficha Completa Activo Fijo") Then
            IdReporte = 4
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Ficha Asignacion Activo Fijo") Then
            IdReporte = 5
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Reporte por Clasificacion - Seguros") Then
            IdReporte = 6
        ElseIf (cb_ReporteTransferencia.SelectedItem = "Reporte General") Then
            IdReporte = 7
        End If
    End Sub

    Sub ActivarBotones()
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
    End Sub

    Private Function ModificarControles(ByVal Bandera As Boolean)
        Dim Ctl As Control
        Dim x As Integer
        For x = gbFiltros.Controls.Count - 1 To 0 Step -1
            Ctl = gbFiltros.Controls.Item(x)
            Ctl.Enabled = Bandera
        Next
    End Function

    Dim DataEmployee As New DataTable

    Private Sub ERP_ReportTrasnfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DataInfo As DataTable
        Try
            cb_ReporteTransferencia.SelectedIndex = 0
            cbOrdenadoPor.SelectedIndex = 0
        Catch ex As Exception

        End Try

        Try
            If _Asistente Then
                ModificarControles(False)
                txtCodigo.Enabled = True
                txtNombre.Enabled = True
                CB_ContactEmploye.Enabled = True
                Label8.Enabled = True
                Label2.Enabled = True
                Label1.Enabled = True
                TabControl1.TabPages.Remove(TabPage1)

                For i As Integer = 1 To cb_ReporteActivoFijo.Items.Count - 1
                    cb_ReporteActivoFijo.Items.RemoveAt(1)
                Next
            End If
        Catch ex As Exception

        End Try

        Try

            Dim dt As New DataTable
            Dim table2 As DataTable
            Using obj As New Generic_SQLServer
                DataInfo = obj.SP_ERP_Inventory_GetLocationPrimary()
            End Using


            Try
                table2 = DataInfo.Clone()
                table2.Rows.Clear()
                'table2.Rows.Add(0, "Todos")
                table2.Merge(DataInfo)
                For i As Integer = 0 To table2.Rows.Count - 1
                    lstUbicacionPrimaria1.Items.Add(table2.Rows(i)("NameLocation").ToString.PadRight(500, " ") & "||" & table2.Rows(i)("ID_Location").ToString.PadLeft(10, "0"))
                Next
            Catch ex As Exception

            End Try


            Using obj As New Generic_SQLServer
                DataInfo = obj.SP_ERP_Inventary_GetUnidadesOrganizativas()
            End Using

            Try
                table2 = DataInfo.Clone()
                table2.Rows.Clear()
                'table2.Rows.Add(0, "Todos")
                table2.Merge(DataInfo)

                For i As Integer = 0 To table2.Rows.Count - 1
                    lstUnida1.Items.Add(table2.Rows(i)("Name_Deparmnet").ToString.PadRight(500, " ") & "||" & table2.Rows(i)("Id_Deparment").ToString.PadLeft(10, "0"))
                Next
            Catch ex As Exception
            End Try

        Catch ex As Exception

        End Try

        Try
            DataInfo = objSqlHumanResources.GetEstados()
            Dim table2 As DataTable = DataInfo.Clone()
            table2.Rows.Clear()
            table2.Rows.Add(0, "Todos")
            table2.Merge(DataInfo)

            cmbEstado.DataSource = table2
            cmbEstado.DisplayMember = "nombreEstado"
            cmbEstado.ValueMember = "id_estado"
            cmbEstado.SelectedIndex = -1

            DataEmployee = objSqlHumanResources.GetEmploye(Data_Id_Company)
            Try
                If _Asistente Then
                    Dim foundRows() As Data.DataRow
                    foundRows = DataEmployee.Select("Id_Department_fK = '" & _Id_DepartmentGlobal.ToString & "'")

                    Dim NewDatatable As New DataTable
                    NewDatatable = DataEmployee.Clone

                    For Each row As DataRow In foundRows
                        NewDatatable.ImportRow(row)
                    Next

                    CB_ContactEmploye.DataSource = NewDatatable


                Else
                    CB_ContactEmploye.DataSource = DataEmployee
                End If
            Catch ex As Exception

            End Try

            CB_ContactEmploye.DisplayMember = "Contact"
            CB_ContactEmploye.ValueMember = "Id_employee"
            CB_ContactEmploye.SelectedIndex = -1
        Catch ex As Exception

        End Try


        Using OBJSQL As New Financiero_SQLServer
            DataInfo = OBJSQL.GetFixedAssetsType(Data_Id_Company)
            Dim table2 As DataTable = DataInfo.Clone()
            table2.Rows.Clear()
            'table2.Rows.Add(0, 0, "Todos")
            table2.Merge(DataInfo)

            For i As Integer = 0 To table2.Rows.Count - 1
                lstClasificacion1.Items.Add(table2.Rows(i)("Name_FixedAssetsType").ToString.PadRight(500, " ") & "||" & table2.Rows(i)("Id_FixedAssetsType").ToString.PadLeft(10, "0"))
            Next
        End Using
    End Sub

    Dim drows() As DataRow
    Dim _DT_DataReporte As New DataTable

    Private Sub ObtenerValores()
        Codigo = txtCodigo.Text.ToString
        If (Codigo.ToString.Trim <> "") Then
            Filtro = "Codigo del Activo :" & Codigo
        End If

        NombreActivo = txtNombre.Text.ToString
        If (NombreActivo.ToString.Trim <> "") Then
            Filtro = "Nombre del Activo :" & NombreActivo
        End If

        If (lstClasificacion2.Items.Count > 0) Then
            Filtro &= " - Clasificación : "
            For i As Integer = 0 To lstClasificacion2.Items.Count - 1
                Dim Data() As String = lstClasificacion2.Items(i).ToString.Split("||")
                Id_Clasificacion &= "'" & Convert.ToInt64(Data(2)) & "', "
                Filtro &= " - " & Data(0).ToString.Trim

            Next
        End If

        If (lstSubClasificacion2.Items.Count > 0) Then
            Filtro &= " - Sub-Clasificación :"
            For i As Integer = 0 To lstSubClasificacion2.Items.Count - 1
                Dim Data() As String = lstSubClasificacion2.Items(i).ToString.Split("||")
                Id_Sub_Clasificacion &= "'" & Convert.ToInt64(Data(2)) & "', "
                Filtro &= " - " & Data(0).ToString.Trim
            Next
        End If


        If (lstUbicacionPrimaria2.Items.Count > 0) Then
            Filtro &= " - Ubicación Primaria: "
            For i As Integer = 0 To lstUbicacionPrimaria2.Items.Count - 1
                Dim Data() As String = lstUbicacionPrimaria2.Items(i).ToString.Split("||")
                UbicacionPrimaria &= "'" & Convert.ToInt64(Data(2)) & "', "
                Filtro &= " - " & Data(0).ToString.Trim
            Next
        End If

        If (lstUbicacionSecundaria2.Items.Count > 0) Then
            Filtro &= " - Ubicación Secundaria:"
            For i As Integer = 0 To lstUbicacionSecundaria2.Items.Count - 1
                Dim Data() As String = lstUbicacionSecundaria2.Items(i).ToString.Split("||")
                UbicacionSecundaria &= "'" & Convert.ToInt64(Data(2)) & "', "
                Filtro &= " - " & Data(0).ToString.Trim
            Next
        End If

        Id_estado_Fk = cmbEstado.SelectedValue
        If (Id_estado_Fk.ToString.Trim <> "" And Id_estado_Fk.ToString.Trim <> 0) Then
            Filtro &= " - Estado :" & cmbEstado.SelectedItem(2)
        End If


        OrdenadoPor = cbOrdenadoPor.SelectedItem
        If (OrdenadoPor.ToString.Trim <> "") Then
            Filtro &= " - Ordenado Por:" & cbOrdenadoPor.SelectedItem
        End If


        Id_Employee = CB_ContactEmploye.SelectedValue
        If (Id_Employee.ToString.Trim <> "" And Id_Employee.ToString.Trim <> 0) Then
            Filtro &= " - Responsable :" & CB_ContactEmploye.SelectedItem(9)
        End If

        If (lstUnida2.Items.Count > 0) Then
            Filtro &= " - Unidad Organizativa: "
            For i As Integer = 0 To lstUnida2.Items.Count - 1
                Dim Data() As String = lstUnida2.Items(i).ToString.Split("||")
                UnidadOrganizativa &= "'" & Convert.ToInt64(Data(2)) & "', "
                Filtro &= " - " & Data(0).ToString.Trim
            Next
        End If

        If (_Asistente) Then
            UnidadOrganizativa = _Id_DepartmentGlobal
        End If

        Try
            RangoFechaAdquisicion = cmbFechaAdquisicion.SelectedItem.ToString.Trim
        Catch ex As Exception
            RangoFechaAdquisicion = ""
        End Try
        Fecha_Ad_Act = 0
        If (RangoFechaAdquisicion <> "") Then
            Fecha_Ad_Act = 1
            FechaAdquisicionInicial = dtpFechaAdquisicion.Value
            If (RangoFechaAdquisicion = "=") Then
                FechaAdquisicionFinal = dtpFechaAdquisicion.Value
                Filtro &= " - Fecha de Adquisición: Igual a : " & FechaAdquisicionInicial.ToString
            ElseIf (RangoFechaAdquisicion = ">=") Then
                FechaAdquisicionFinal = dtpFechaAdquisicion.Value.AddYears(50)
                Filtro &= " - Fecha de Adquisición: Mayor o igual a : " & FechaAdquisicionInicial.ToString
            ElseIf (RangoFechaAdquisicion = "<=") Then
                Filtro &= " - Fecha de Adquisición: Menor o igual a : " & FechaAdquisicionInicial.ToString("dd/MM/yyyy")
                FechaAdquisicionFinal = FechaAdquisicionInicial
                FechaAdquisicionInicial = FechaAdquisicionInicial.AddYears(-15)

            End If
        Else
            FechaAdquisicionInicial = Nothing
            FechaAdquisicionFinal = Nothing
        End If


        Try
            RangoValorAdquisicion = cmbValorAdquisicion.SelectedItem.ToString.Trim
        Catch ex As Exception
            RangoValorAdquisicion = ""
        End Try
        Valor_Ad_Act = 0
        If (RangoValorAdquisicion <> "") Then
            If (txtValorAdquisicion.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el valor de Adquisicion a procesar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtValorAdquisicion.Focus()
                Exit Sub
            End If
            Valor_Ad_Act = 1
            ValorAdquisicionInicial = Convert.ToDouble(txtValorAdquisicion.Text.ToString)
            If (RangoValorAdquisicion = "=") Then
                ValorAdquisicionFinal = ValorAdquisicionInicial
                Filtro &= " - Valor Adquisición: Igual a : " & ValorAdquisicionInicial.ToString
            ElseIf (RangoValorAdquisicion = ">=") Then
                ValorAdquisicionFinal = 99999999999
                Filtro &= " - Valor Adquisición: Mayor o igual a : " & ValorAdquisicionInicial.ToString
            ElseIf (RangoValorAdquisicion = "<=") Then
                ValorAdquisicionFinal = ValorAdquisicionInicial
                Filtro &= " - Valor Adquisición: Menor a : " & ValorAdquisicionFinal.ToString
                ValorAdquisicionInicial = 0
                'Filtro &= " - Valor Adquisición: Menor a : " & ValorAdquisicionInicial.ToString

            End If
        Else
            ValorAdquisicionInicial = Nothing
            ValorAdquisicionFinal = Nothing
        End If


        Ubicacion = 0
        If (chkFechas.Checked) Then
            FechaDescargoInicial = dtpFechaDesde.Value
            FechaDescargoFinal = dtpFechaHasta.Value

            Filtro &= " - Fecha de Reporte: desde: " & FechaDescargoInicial.ToString("dd/MM/yyyy") & " hasta: " & FechaDescargoFinal.ToString("dd/MM/yyyy")

        Else
            FechaDescargoInicial = Now.AddYears(-200)
            FechaDescargoFinal = Now.AddYears(300)
        End If



        Try
            RangoVidaUtil = cmbVidaUtil.SelectedItem.ToString.Trim
            VidaUtilInicial = 0
            VidaUtilFinal = 0
            If (RangoVidaUtil <> "") Then
                VidaUtilInicial = Convert.ToInt32(txtVidaUtil.Text.ToString)

                If (RangoVidaUtil = "=") Then
                    VidaUtilFinal = VidaUtilInicial
                    Filtro &= " - Vida Util: Igual a : " & VidaUtilInicial.ToString & " años "
                ElseIf (RangoVidaUtil = ">=") Then
                    VidaUtilFinal = Convert.ToInt32(txtVidaUtil.Text.ToString) + 2500
                    Filtro &= " - Vida Util: Mayor o Igual a : " & VidaUtilInicial.ToString & " años "
                ElseIf (RangoVidaUtil = "<=") Then
                    VidaUtilFinal = VidaUtilInicial
                    VidaUtilInicial = 0
                    Filtro &= " - Vida Util: Menor o Igual a : " & VidaUtilInicial.ToString & " años "
                End If
            End If
        Catch ex As Exception
            VidaUtilInicial = 0
            VidaUtilFinal = 0
        End Try

        If (Filtro = "") Then
            Filtro = "Reporte General"
        End If

        Id_Clasificacion = EliminarComa(Id_Clasificacion)
        Id_Sub_Clasificacion = EliminarComa(Id_Sub_Clasificacion)
        UbicacionPrimaria = EliminarComa(UbicacionPrimaria)
        UbicacionSecundaria = EliminarComa(UbicacionSecundaria)
        UnidadOrganizativa = EliminarComa(UnidadOrganizativa)
        FechasAct = False
        If chkFechas.Checked Then
            FechasAct = True
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Id_Clasificacion = ""
        Id_Sub_Clasificacion = ""
        UbicacionPrimaria = ""
        UbicacionSecundaria = ""
        UnidadOrganizativa = ""
        Codigo = ""
        NombreActivo = ""
        Filtro = ""
        Id_Employee = 0
        RangoValorAdquisicionInicial = 0
        RangoValorAdquisicionFinal = 0

        If cmdSave.Text = "Reporte Trans." Then
            If cb_ReporteTransferencia.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


        Else
            If cb_ReporteActivoFijo.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If


        ObtenerValores()


        PnProcesando.Visible = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        Control.CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()



    End Sub

    Dim cadCor As String = ""
    Private Function EliminarComa(ByVal Cadenas As String)
        If (Cadenas.ToString.Length > 2) Then
            cadCor = Cadenas.ToString.Substring(0, Cadenas.ToString.Length - 2)
            Return cadCor
        Else
            Return Cadenas
        End If
    End Function

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private abierto As Integer = 1

    Private Sub cmbVidaUtil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVidaUtil.SelectedIndexChanged
        If (cmbVidaUtil.SelectedItem.ToString.Trim <> "") Then
            txtVidaUtil.Enabled = True
        Else
            txtVidaUtil.Enabled = False
        End If
    End Sub

    Private Sub cmbFechaAdquisicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFechaAdquisicion.SelectedIndexChanged
        If (cmbFechaAdquisicion.SelectedItem.ToString.Trim <> "") Then
            dtpFechaAdquisicion.Enabled = True
        Else
            dtpFechaAdquisicion.Enabled = False
        End If
    End Sub

    Private Sub cmbValorAdquisicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbValorAdquisicion.SelectedIndexChanged
        If (cmbValorAdquisicion.SelectedItem.ToString.Trim <> "") Then
            txtValorAdquisicion.Enabled = True
        Else
            txtValorAdquisicion.Enabled = False
        End If
    End Sub

    Private Sub cmbClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LlenaCbxSub(ByVal id_Company As Long, FixedAssetsType As Int64)

        _dtixedAssetsType_sub = objSql.GetFixedAssetsType_Sub(Data_Id_Company, FixedAssetsType)
        lstSubClasificacion1.Items.Clear()

        'lstSubClasificacion1.Items.Add("Todos".ToString.PadRight(500, " ") & "||" & "".ToString.PadLeft(10, "0"))

        Try
            For i As Integer = 0 To _dtixedAssetsType_sub.Rows.Count - 1
                lstSubClasificacion1.Items.Add(_dtixedAssetsType_sub.Rows(i)("Name_FixedAssetsType").ToString.PadRight(500, " ") & "||" & _dtixedAssetsType_sub.Rows(i)("Id_FixedAssetsType_Sub").ToString.PadLeft(10, "0"))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtVidaUtil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVidaUtil.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorAdquisicion.KeyPress
        NumerosyDecimal(txtValorAdquisicion, e)
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


    Public Event DropDownOpened As EventHandler

    Private Sub cmbClasificacion_DropDown(sender As Object, e As EventArgs)
        abierto = 0
    End Sub

    Private Sub cmbClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbClasificacion_DropDownClosed(sender As Object, e As EventArgs)
        abierto = 1
    End Sub


    Private Sub cmbSubClasificacion_DropDown(sender As Object, e As EventArgs)
        abierto = 0
    End Sub

    Private Sub cmbSubClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbSubClasificacion_DropDownClosed(sender As Object, e As EventArgs)
        abierto = 1
    End Sub

    Private Sub CB_ContactEmploye_DropDown(sender As Object, e As EventArgs) Handles CB_ContactEmploye.DropDown
        abierto = 0
    End Sub

    Private Sub CB_ContactEmploye_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ContactEmploye.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CB_ContactEmploye_DropDownClosed(sender As Object, e As EventArgs) Handles CB_ContactEmploye.DropDownClosed
        abierto = 1
    End Sub


    Private Sub cmbEstado_DropDown(sender As Object, e As EventArgs) Handles cmbEstado.DropDown
        abierto = 0
    End Sub

    Private Sub cmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEstado.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbEstado_DropDownClosed(sender As Object, e As EventArgs) Handles cmbEstado.DropDownClosed
        abierto = 1
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


    Private BanderaReporte As Boolean = True
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BanderaReporte = True
        Dim fechaInicial As String = FechaDescargoInicial.ToString("yyyy-MM-dd")
        Dim fechaFinal As String = FechaDescargoFinal.ToString("yyyy-MM-dd")
        dt = Nothing
        Select Case IdReporte
            Case 0
                _MostrarFiltro = True
                _FiltradoPor = Filtro


                If (fechaInicial > fechaFinal) Then
                    MessageBox.Show("La fecha inicial es mayor que la final", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpFechaAdquisicion.Focus()
                    BanderaReporte = False
                Else
                    dt = objGeneric.ERP_GetBodyReportInventory_transfers(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End If

            Case 1
                _MostrarFiltro = True
                _FiltradoPor = Filtro
                If (fechaInicial > fechaFinal) Then
                    MessageBox.Show("La fecha inicial es mayor que la final", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpFechaAdquisicion.Focus()
                    BanderaReporte = False
                End If
                If Not cmbEstado.SelectedIndex = -1 Then
                    dt = objGeneric.ERP_GetBodyReportFiexdAssetsState(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                Else
                    dt = Nothing
                    MessageBox.Show("Selecione un estado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cmbEstado.Focus()
                    BanderaReporte = False
                End If
            Case 2
                dt = objGeneric.ERP_GetBodyReportFiexdAssetsGeneral(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                _MostrarFiltro = True
                _FiltradoPor = Filtro
            Case 3
                dt = objGeneric.ERP_GetBodyReportFiexdAssetstYPE(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                _FiltradoPor = Filtro
                _MostrarFiltro = True
            Case 4
                dt = objGeneric.ERP_GetBodyReportFiexdAssetsGeneral(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                Dim imagen As Bitmap
                Dim fileName As String = ""

                Try
                    If dt.Rows.Count > 0 Then
                        Dim b As BarcodeLib.Barcode = New BarcodeLib.Barcode()
                        b.Alignment = BarcodeLib.AlignmentPositions.CENTER
                        Dim type As BarcodeLib.TYPE = BarcodeLib.TYPE.UNSPECIFIED
                        type = BarcodeLib.TYPE.CODE128A
                        b.IncludeLabel = False
                        b.RotateFlipType = System.Drawing.RotateFlipType.RotateNoneFlipNone
                        b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER

                        Dim W As Integer = 400
                        Dim H As Integer = 125
                        folder = Path.Combine(Application.StartupPath, "ImageDataSheet")

                        If (Not Directory.Exists(folder)) Then
                            Directory.CreateDirectory(folder)
                        End If

                        For Each item As DataRow In dt.Rows

                            imagen = b.Encode(type, item("Codigo"), Color.Black, Color.White, W, H)
                            PictureBox1.Image = imagen
                            fileName = Path.Combine(folder, item("Codigo") & ".jpg")
                            PictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                            item("CodBarras") = "file:///" & fileName
                        Next

                    End If
                Catch ex As Exception

                End Try


                _MostrarFiltro = True
                _FiltradoPor = Filtro
            Case 5
                dt = objGeneric.ERP_GetBodyReportFiexdAssetsGeneral(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                _MostrarFiltro = True
                _FiltradoPor = Filtro
            Case 6
                _FiltradoPor = Filtro
                _MostrarFiltro = True

                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using
            Case 7
                _FiltradoPor = Filtro
                _MostrarFiltro = True

                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                         UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                         FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using
            Case 8
                _FiltradoPor = Filtro
                _MostrarFiltro = True
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                 UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                 FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using
            Case 9
                _FiltradoPor = Filtro
                _MostrarFiltro = True
                If Codigo.ToString.Trim = "" Then
                    MessageBox.Show("Debe de ingresar un codigo de Barra del Producto", Application.CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijoContable(_ID_Company, Codigo, fechaInicial, fechaFinal)
                End Using

            Case 10
                _FiltradoPor = Filtro
                _MostrarFiltro = True
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_inventory_Cuadro_Depreciacion(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                 UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                 FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using
            Case 11
                _FiltradoPor = Filtro
                _MostrarFiltro = True
                Using ObjSQL As New Operaciones_SQLServer
                    dt = ObjSQL.SP_ERP_Inventory_ReporteTransparencia(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                 UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                 FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using
            Case 12
                _FiltradoPor = Filtro
                _MostrarFiltro = True
                Using ObjSQL As New Operaciones_SQLServer
                    dt = ObjSQL.SP_ERP_Inventory_Detalle_General_Bienes(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                 UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                 FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using
            Case 13
                If Codigo <> "" Then

                    Using Obj As New Operaciones_SQLServer
                        dt = Obj.SP_ERP_Inventory_ReportePeriodicoDepreciacionActivoFijo(fechaInicial, fechaFinal, Codigo)

                    End Using
                Else
                    MessageBox.Show("Debe de ingresar un Codigo de Producto para generar el reporte.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCodigo.Focus()
                    Exit Sub
                End If
            Case 14
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_RegistroContableAltasBaja(fechaInicial, fechaFinal)
                End Using
            Case 15
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_ReportePeriodicoAltas(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                 UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                 FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act)
                End Using

            Case 16
                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_ReportePeriodicoBajas(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                                                                 UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                                                                 FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act)
                End Using


            Case 17

                Using Obj As New Operaciones_SQLServer
                    ' dt = Obj.SP_ERP_Inventory_ReporteAmortizacion(_ID_Company, Codigo, NombreActivo, Id_Clasificacion.ToString, Id_Sub_Clasificacion.ToString, UbicacionPrimaria,
                    'UbicacionSecundaria, UnidadOrganizativa, Id_Employee, fechaInicial, fechaFinal, Id_estado_Fk, FechaAdquisicionInicial,
                    'FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, FechasAct, Fecha_Ad_Act, Valor_Ad_Act, OrdenadoPor)
                End Using

            Case Else
                MessageBox.Show("Seleccione un tipo de reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cb_ReporteTransferencia.Focus()
                BanderaReporte = False
        End Select
        Try
            If dt.Rows.Count > 0 Then
                BanderaReporte = True
            Else
                BanderaReporte = False
            End If
        Catch ex As Exception
            BanderaReporte = False
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If (BanderaReporte = True) Then

            PnProcesando.Visible = False
            Dim objPartidaContable As Financiero_ReportViewer

            Try
                Select Case IdReporte
                    Case 0
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DtTransferenciasActivos", "epd_SatelliteERP.Reporte_InventarioActivosTrasferencia.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("No hay datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Case 1
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DtActivosPorEstado", "epd_SatelliteERP.Reporte_InventarioActivosPorEstado.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 2
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "ReportAssetssGeneral", "epd_SatelliteERP.Reporte_FixedAssets_General.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 3
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "ReportTypeAssets", "epd_SatelliteERP.Reporte_FixedAssetsType.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 4
                        If dt.Rows.Count > 0 Then
                            Try
                                If dt.Rows.Count > 0 Then
                                    objPartidaContable = New Financiero_ReportViewer(dt, "ReportAssetssGeneral", "epd_SatelliteERP.Reporte_FixedAssets_DataSheet.rdlc")
                                    objPartidaContable.StartPosition = FormStartPosition.CenterScreen

                                Else
                                    MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception

                            End Try
                        End If
                    Case 5
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "ReportAssetssGeneral", "epd_SatelliteERP.Reporte_FixedAssets_Asignacion.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 6
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Resumida_ActivoSeguro.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 7
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.ReporteGeneralActivoFijo.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 8
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Resumida_Activo.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 9
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Contable_Depreciacion.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 10
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Cuadro_Depreciacion.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case 11
                        If dt.Rows.Count > 0 Then
                            objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Transparencia.rdlc")
                            objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                        Else
                            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Case 12
                        Try
                            If dt.Rows.Count > 0 Then
                                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_Detalle_General_Bienes_Capitalizables.rdlc")
                                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                            Else
                                MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception

                        End Try
                    Case 13
                        Try
                            If dt.Rows.Count > 0 Then
                                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Reporte_periodico_Depreciacion_Activos.rdlc")
                                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                            Else
                                MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception

                        End Try
                    Case 14
                        Try
                            If dt.Rows.Count > 0 Then
                                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Registro_Contable_Altas_Bajas_Activo.rdlc")
                                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                            Else
                                MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception

                        End Try
                    Case 15
                        Try
                            If dt.Rows.Count > 0 Then
                                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Altas_Activo_Fijo.rdlc")

                                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                            Else
                                MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception

                        End Try
                    Case 16
                        Try
                            If dt.Rows.Count > 0 Then
                                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Bajas_Activo_Fijo.rdlc")

                                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                            Else
                                MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception

                        End Try
                    Case 17
                        Try
                            If dt.Rows.Count > 0 Then
                                objPartidaContable = New Financiero_ReportViewer(dt, "Informacion", "epd_SatelliteERP.Reporte_deAmortizacion.rdlc")

                                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
                            Else
                                MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As Exception

                        End Try
                    Case Else
                        MessageBox.Show("Seleccione un tipo de reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        cb_ReporteTransferencia.Focus()
                End Select
                objPartidaContable.ShowDialog()
            Catch ex As Exception
                'MessageBox.Show("No hay informacion para generar el Reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Try
                My.Computer.FileSystem.DeleteDirectory(folder, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Sin datos que mostrar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            PnProcesando.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To lstClasificacion1.SelectedItems.Count - 1
            lstClasificacion2.Items.Add(lstClasificacion1.SelectedItems(i))
            lstClasificacion1.Items.Remove(lstClasificacion1.SelectedItems(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To lstClasificacion2.SelectedItems.Count - 1
            lstClasificacion1.Items.Add(lstClasificacion2.SelectedItems(i))
            lstClasificacion2.Items.Remove(lstClasificacion2.SelectedItems(i))
        Next
        Try
            lstSubClasificacion1.Items.Clear()
            lstSubClasificacion2.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstClasificacion2_MouseClick(sender As Object, e As MouseEventArgs) Handles lstClasificacion2.MouseClick
        Try
            If Not lstClasificacion2.SelectedItems(0) = "" Then
                Dim Datos() As String = lstClasificacion2.SelectedItems(0).ToString.Split("||")
                LlenaCbxSub(Data_Id_Company, Convert.ToInt64(Datos(2)))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To lstSubClasificacion1.SelectedItems.Count - 1
            lstSubClasificacion2.Items.Add(lstSubClasificacion1.SelectedItems(i))
            lstSubClasificacion1.Items.Remove(lstSubClasificacion1.SelectedItems(i))
        Next
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For i As Integer = 0 To lstUbicacionPrimaria1.SelectedItems.Count - 1
            lstUbicacionPrimaria2.Items.Add(lstUbicacionPrimaria1.SelectedItems(i))
            lstUbicacionPrimaria1.Items.Remove(lstUbicacionPrimaria1.SelectedItems(i))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To lstSubClasificacion2.SelectedItems.Count - 1
            lstSubClasificacion1.Items.Add(lstSubClasificacion2.SelectedItems(i))
            lstSubClasificacion2.Items.Remove(lstSubClasificacion2.SelectedItems(i))
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For i As Integer = 0 To lstUbicacionPrimaria2.SelectedItems.Count - 1
            lstUbicacionPrimaria1.Items.Add(lstUbicacionPrimaria2.SelectedItems(i))
            lstUbicacionPrimaria2.Items.Remove(lstUbicacionPrimaria2.SelectedItems(i))
        Next
        Try
            lstUbicacionSecundaria1.Items.Clear()
            lstUbicacionSecundaria2.Items.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For i As Integer = 0 To lstUbicacionSecundaria2.SelectedItems.Count - 1
            lstUbicacionSecundaria1.Items.Add(lstUbicacionSecundaria2.SelectedItems(i))
            lstUbicacionSecundaria2.Items.Remove(lstUbicacionSecundaria2.SelectedItems(i))
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For i As Integer = 0 To lstUbicacionSecundaria1.SelectedItems.Count - 1
            lstUbicacionSecundaria2.Items.Add(lstUbicacionSecundaria1.SelectedItems(i))
            lstUbicacionSecundaria1.Items.Remove(lstUbicacionSecundaria1.SelectedItems(i))
        Next
    End Sub

    Private Sub lstUbicacionPrimaria2_MouseClick(sender As Object, e As MouseEventArgs) Handles lstUbicacionPrimaria2.MouseClick
        Dim _dtLocation As New DataTable
        lstUbicacionSecundaria1.Items.Clear()

        Try
            If Not lstUbicacionPrimaria2.SelectedItems(0) = "" Then
                Dim Datos() As String = lstUbicacionPrimaria2.SelectedItems(0).ToString.Split("||")
                _dtLocation = objSqlHumanResources.GetLocationByPrimary(Data_Id_Company, Convert.ToInt64(Datos(2)))
                'lstUbicacionSecundaria1.Items.Add("Todos".ToString.PadRight(500, " ") & "||" & "".ToString.PadLeft(10, "0"))
                Try
                    For i As Integer = 0 To _dtLocation.Rows.Count - 1
                        lstUbicacionSecundaria1.Items.Add(_dtLocation.Rows(i)("Name_Location").ToString.PadRight(500, " ") & "||" & _dtLocation.Rows(i)("Id_Location").ToString.PadLeft(10, "0"))
                    Next
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        For i As Integer = 0 To lstUnida1.SelectedItems.Count - 1
            lstUnida2.Items.Add(lstUnida1.SelectedItems(i))
            lstUnida1.Items.Remove(lstUnida1.SelectedItems(i))
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For i As Integer = 0 To lstUnida2.SelectedItems.Count - 1
            lstUnida1.Items.Add(lstUnida2.SelectedItems(i))
            lstUnida2.Items.Remove(lstUnida2.SelectedItems(i))
        Next
    End Sub

    Private Sub btnLimpieza_Click(sender As Object, e As EventArgs) Handles btnLimpieza.Click
        Try
            lstClasificacion1.Items.Clear()
            lstClasificacion2.Items.Clear()
            lstSubClasificacion2.Items.Clear()
            lstSubClasificacion2.Items.Clear()
            lstUbicacionSecundaria1.Items.Clear()
            lstUbicacionSecundaria2.Items.Clear()
            lstSubClasificacion1.Items.Clear()
            lstUnida2.Items.Clear()
            CB_ContactEmploye.SelectedIndex = -1
            cmbEstado.SelectedIndex = -1
            cmbFechaAdquisicion.SelectedIndex = -1
            cmbValorAdquisicion.SelectedIndex = -1
            txtCodigo.Text = ""
            txtNombre.Text = ""
        Catch ex As Exception

        End Try
        ERP_ReportTrasnfer_Load(Nothing, Nothing)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechas.CheckedChanged
        If chkFechas.Checked = True Then
            dtpFechaDesde.Enabled = True
            dtpFechaHasta.Enabled = True
        Else
            dtpFechaDesde.Enabled = False
            dtpFechaHasta.Enabled = False
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedIndex = 0) Then
            cmdSave.Text = "Reporte Trans."
        ElseIf (TabControl1.SelectedIndex = 1) Then
            cmdSave.Text = "Reporte Act."
        End If
    End Sub

    Private Sub cb_ReporteActivoFijo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ReporteActivoFijo.SelectedIndexChanged
        'ModificarControles(True)
        'dtpFechaDesde.Enabled = False
        'dtpFechaHasta.Enabled = False
        'chkFechas.Checked = False
        If (cb_ReporteActivoFijo.SelectedItem = "Reporte Ficha Resumida Activo") Then
            IdReporte = 8
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Historico de Depreciación de Activo") Then
            IdReporte = 9
            ModificarControles(False)
            dtpFechaDesde.Enabled = True
            dtpFechaHasta.Enabled = True
            chkFechas.Enabled = True
            chkFechas.Checked = True
            txtCodigo.Enabled = True
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Cuadro Depreciación") Then
            IdReporte = 10
            chkFechas.Checked = False
            cbOrdenadoPor.Enabled = False
            'odificarControles(False)
            'chkFechas.Enabled = True
            'chkFechas.Checked = True
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Ficha Transparencia") Then
            IdReporte = 11
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Detalle Bienes Capitalizables") Then
            IdReporte = 12
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Períodico Depreciación Activos") Then
            IdReporte = 13
            ModificarControles(False)
            dtpFechaDesde.Enabled = True
            chkFechas.Checked = True
            chkFechas.Enabled = True
            dtpFechaHasta.Enabled = True
            txtCodigo.Enabled = True
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Contable Altas y Bajas de Activo") Then
            IdReporte = 14
            ModificarControles(False)
            chkFechas.Enabled = True
            chkFechas.Checked = True
            dtpFechaDesde.Enabled = True
            dtpFechaHasta.Enabled = True
            txtCodigo.Enabled = True
            txtCodigo.Text = ""
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Períodico de Altas Activo") Then
            IdReporte = 15
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte Períodico de Bajas Activo") Then
            IdReporte = 16
        ElseIf (cb_ReporteActivoFijo.SelectedItem = "Reporte de Amortización") Then
            IdReporte = 17
        End If
    End Sub
End Class