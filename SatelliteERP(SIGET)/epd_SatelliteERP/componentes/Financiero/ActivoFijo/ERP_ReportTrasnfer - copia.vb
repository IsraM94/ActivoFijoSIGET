Imports System.IO

Public Class ERP_ReportTrasnfer
    Private objSqlHumanResources As New HumanResources_SQLServer
    Private objSql As New Financiero_SQLServer
    Private objGeneric As New Generic_SQLServer
    Private Reporte As String = ""
    Private Codigo As String = ""
    Private NombreActivo As String = ""
    Private Id_Clasificacion As Integer = 0
    Private Id_Sub_Clasificacion As Integer = 0
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
    Private UbicacionPrimaria As Integer = 0
    Private UbicacionSecundaria As Integer = 0
    Private UnidadOrganizativa As Integer = 0
    Private _dtixedAssetsType_sub As DataTable
    Private IdReporte = 0

    Private folder As String = ""
    Dim dt As New DataTable
    Private Sub cb_Reporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Reporte.SelectedIndexChanged
        If (cb_Reporte.SelectedIndex = 0) Then
            ModificarControles(False)
            dtpFechaDesde.Enabled = True
            dtpFechaHasta.Enabled = True
            cmbClasificacion.Enabled = True
            cmbVidaUtil.Enabled = True
            txtVidaUtil.Enabled = True
            Exit Sub
        End If
        If (cb_Reporte.SelectedIndex = 1) Then
            ModificarControles(False)
            cmbEstado.Enabled = True
            Exit Sub
        End If

        If (cb_Reporte.SelectedIndex = 2) Then
            ModificarControles(True)
            dtpFechaAdquisicion.Enabled = False
            dtpFechaDesde.Enabled = False
            dtpFechaHasta.Enabled = False
            txtValorAdquisicion.Enabled = False
            CB_ContactEmploye.Enabled = False
            Exit Sub
        End If

        If (cb_Reporte.SelectedIndex = 3) Then
            ModificarControles(False)
            cmbClasificacion.Enabled = True
            Exit Sub
        End If

        If (cb_Reporte.SelectedIndex = 4) Then
            ModificarControles(True)
            cmbClasificacion.Enabled = True
            dtpFechaDesde.Enabled = False
            dtpFechaHasta.Enabled = False
            CB_ContactEmploye.Enabled = False
            Exit Sub
        End If

        If (cb_Reporte.SelectedIndex = 5) Then
            ModificarControles(True)
            dtpFechaAdquisicion.Enabled = False
            dtpFechaDesde.Enabled = False
            dtpFechaHasta.Enabled = False
            txtCodigo.Enabled = False
            txtNombre.Enabled = False
            cmbEstado.Enabled = False
            txtValorAdquisicion.Enabled = False
            CB_ContactEmploye.Enabled = True
            Exit Sub
        End If

        If (cb_Reporte.SelectedIndex = 6) Then
            ModificarControles(True)
            dtpFechaAdquisicion.Enabled = False
            dtpFechaDesde.Enabled = False
            dtpFechaHasta.Enabled = False
            txtCodigo.Enabled = False
            txtNombre.Enabled = False
            cmbEstado.Enabled = False
            txtValorAdquisicion.Enabled = False
            CB_ContactEmploye.Enabled = True
            Exit Sub
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
        Dim DataInfo As DataTable
        Try

            Dim dt As New DataTable
            Dim table2 As DataTable
            Using obj As New Generic_SQLServer
                DataInfo = obj.SP_ERP_Inventory_GetLocationPrimary()
            End Using


            Try
                table2 = DataInfo.Clone()
                table2.Rows.Clear()
                table2.Rows.Add(0, "Todos")
                table2.Merge(DataInfo)

                cmb_UbicaconPrimaria.DataSource = table2
                cmb_UbicaconPrimaria.ValueMember = "ID_Location"
                cmb_UbicaconPrimaria.DisplayMember = "NameLocation"
                cmb_UbicaconPrimaria.SelectedIndex = -1

            Catch ex As Exception

            End Try


            Using obj As New Generic_SQLServer
                DataInfo = obj.SP_ERP_Inventory_GetLocationSecundary()
            End Using

            Try
                table2 = DataInfo.Clone()
                table2.Rows.Clear()
                table2.Rows.Add(0, "Todos")
                table2.Merge(DataInfo)

                cmb_UbicaconSecundaria.DataSource = table2
                cmb_UbicaconSecundaria.ValueMember = "Id_Location"
                cmb_UbicaconSecundaria.DisplayMember = "Name_Location"
                cmb_UbicaconSecundaria.SelectedIndex = -1
            Catch ex As Exception

            End Try



            Using obj As New Generic_SQLServer
                DataInfo = obj.SP_ERP_Inventary_GetUnidadesOrganizativas()
            End Using

            Try
                table2 = DataInfo.Clone()
                table2.Rows.Clear()
                table2.Rows.Add(0, "Todos")
                table2.Merge(DataInfo)

                cmb_Unidad.DataSource = table2
                cmb_Unidad.ValueMember = "Id_Deparment"
                cmb_Unidad.DisplayMember = "Name_Deparmnet"
                cmb_Unidad.SelectedIndex = -1
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


            CB_ContactEmploye.DataSource = objSqlHumanResources.GetEmploye(Data_Id_Company)
            CB_ContactEmploye.DisplayMember = "Contact"
            CB_ContactEmploye.ValueMember = "Id_employee"
            CB_ContactEmploye.SelectedIndex = -1
        Catch ex As Exception

        End Try


        Using OBJSQL As New Financiero_SQLServer
            DataInfo = OBJSQL.GetFixedAssetsType(Data_Id_Company)
            Dim table2 As DataTable = DataInfo.Clone()
            table2.Rows.Clear()
            table2.Rows.Add(0, 0, "Todos")
            table2.Merge(DataInfo)
            'cmbClasificacion.DataSource = table2
            'cmbClasificacion.DisplayMember = "Name_FixedAssetsType"
            'cmbClasificacion.ValueMember = "Id_FixedAssetsType"

            For i As Integer = 0 To table2.Rows.Count - 1
                lstClasificacion1.Items.Add(table2.Rows(i)("Name_FixedAssetsType").ToString.PadRight(500, " ") & "||" & table2.Rows(i)("Id_FixedAssetsType").ToString.PadLeft(10, "0"))
            Next

            'lstClasificacion1.DataSource = table2
            'lstClasificacion1.DisplayMember = "Name_FixedAssetsType"
            'lstClasificacion1.ValueMember = "Id_FixedAssetsType"
            cmbClasificacion.SelectedIndex = -1

        End Using

        dtpFechaAdquisicion.Enabled = False
        txtValorAdquisicion.Enabled = False
        dtpFechaDesde.Enabled = False
        dtpFechaHasta.Enabled = False
        txtVidaUtil.Enabled = False
    End Sub

    Dim drows() As DataRow
    Dim _DT_DataReporte As New DataTable

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Filtro = ""
        IdReporte = cb_Reporte.SelectedIndex
        If cb_Reporte.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Codigo = txtCodigo.Text.ToString
        If (Codigo.ToString.Trim <> "") Then
            Filtro = "Codigo del Activo :" & Codigo
        End If

        NombreActivo = txtNombre.Text.ToString
        If (NombreActivo.ToString.Trim <> "") Then
            Filtro = "Nombre del Activo :" & NombreActivo
        End If
        Id_Clasificacion = cmbClasificacion.SelectedValue
        If (Id_Clasificacion.ToString.Trim <> "" And Id_Clasificacion.ToString.Trim <> 0) Then
            Filtro &= " - Clasificación :" & cmbClasificacion.SelectedItem(2).ToString
        End If

        Id_Sub_Clasificacion = cmbSubClasificacion.SelectedValue

        If (Id_Sub_Clasificacion.ToString.Trim <> "" And Id_Sub_Clasificacion.ToString.Trim <> 0) Then
            Filtro &= " - Sub_Clasificación :" & cmbSubClasificacion.SelectedItem(3).ToString
        End If

        Id_estado_Fk = cmbEstado.SelectedValue
        If (Id_estado_Fk.ToString.Trim <> "" And Id_estado_Fk.ToString.Trim <> 0) Then
            Filtro &= " - Estado :" & cmbEstado.SelectedItem(2)
        End If

        Id_Employee = CB_ContactEmploye.SelectedValue
        If (Id_Employee.ToString.Trim <> "" And Id_Employee.ToString.Trim <> 0) Then
            Filtro &= " - Responsable :" & CB_ContactEmploye.SelectedItem(9)
        End If

        UbicacionPrimaria = cmb_UbicaconPrimaria.SelectedValue
        If (UbicacionPrimaria.ToString.Trim <> "" And UbicacionPrimaria.ToString.Trim <> 0) Then
            Filtro &= " - Ubicación Primaria:" & cmb_UbicaconPrimaria.SelectedItem(1)
        End If

        UbicacionSecundaria = cmb_UbicaconSecundaria.SelectedValue
        If (UbicacionSecundaria.ToString.Trim <> "" And UbicacionSecundaria.ToString.Trim <> 0) Then
            Filtro &= " - Ubicación Secundaria:" & cmb_UbicaconSecundaria.SelectedItem(2)
        End If

        UnidadOrganizativa = cmb_Unidad.SelectedValue
        If (UnidadOrganizativa.ToString.Trim <> "" And UnidadOrganizativa.ToString.Trim <> 0) Then
            Filtro &= " - Unidad Organizativa:" & cmb_Unidad.SelectedItem(1)
        End If

        Try
            RangoFechaAdquisicion = cmbFechaAdquisicion.SelectedItem.ToString.Trim
        Catch ex As Exception
            RangoFechaAdquisicion = ""
        End Try
        If (RangoFechaAdquisicion <> "") Then
            FechaAdquisicionInicial = dtpFechaAdquisicion.Value
            If (RangoFechaAdquisicion = "=") Then
                FechaAdquisicionFinal = dtpFechaAdquisicion.Value
                Filtro &= " - Fecha de Adquisición: Igual a : " & FechaAdquisicionInicial.ToString
            ElseIf (RangoFechaAdquisicion = ">=") Then
                FechaAdquisicionFinal = dtpFechaAdquisicion.Value.AddYears(15)
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
        If (RangoValorAdquisicion <> "") Then
            If (txtValorAdquisicion.Text.ToString = "") Then
                MessageBox.Show("Debe ingresar el valor de Adquisicion a procesar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtValorAdquisicion.Focus()
                Exit Sub
            End If
            ValorAdquisicionInicial = Convert.ToDouble(txtValorAdquisicion.Text.ToString)
            If (RangoValorAdquisicion = "=") Then
                ValorAdquisicionFinal = ValorAdquisicionInicial
                Filtro &= " - Valor Adquisición: Igual a : " & ValorAdquisicionInicial.ToString
            ElseIf (RangoValorAdquisicion = ">=") Then
                ValorAdquisicionFinal = Convert.ToDouble(txtValorAdquisicion.Text.ToString) + 10000
                Filtro &= " - Valor Adquisición: Mayor o igual a : " & ValorAdquisicionInicial.ToString
            ElseIf (RangoValorAdquisicion = "<=") Then
                ValorAdquisicionFinal = ValorAdquisicionInicial
                ValorAdquisicionInicial = 0
                Filtro &= " - Valor Adquisición: Menor o igual a : " & ValorAdquisicionInicial.ToString
            End If
        Else
            ValorAdquisicionInicial = Nothing
            ValorAdquisicionFinal = Nothing
        End If


        Ubicacion = 0
        If (dtpFechaDesde.Enabled = True And dtpFechaHasta.Enabled = True) Then
            FechaDescargoInicial = dtpFechaDesde.Value
            FechaDescargoFinal = dtpFechaHasta.Value

            Filtro &= " - Fecha de Reporte: desde: " & FechaDescargoInicial.ToString("dd/MM/yyyy") & " hasta: " & FechaDescargoInicial.ToString("dd/MM/yyyy")

        Else
            FechaDescargoInicial = Nothing
            FechaDescargoFinal = Nothing
        End If



        Try
            RangoVidaUtil = cmbVidaUtil.SelectedItem.ToString.Trim
            VidaUtilInicial = 0
            VidaUtilFinal = 0
            If (RangoVidaUtil <> "") Then
                VidaUtilInicial = Convert.ToInt32(txtVidaUtil.Text.ToString)

                If (RangoVidaUtil = "=") Then
                    VidaUtilFinal = Convert.ToInt32(txtVidaUtil.Text.ToString)
                    Filtro &= " - Vida Util: Igual a : " & VidaUtilInicial.ToString & " años "
                ElseIf (RangoVidaUtil = ">=") Then
                    VidaUtilFinal = Convert.ToInt32(txtVidaUtil.Text.ToString) + 250
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
        PnProcesando.Visible = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        Control.CheckForIllegalCrossThreadCalls = True
        BackgroundWorker1.RunWorkerAsync()

        'cb_Reporte.SelectedIndex = -1
        txtCodigo.Text = ""
        txtNombre.Text = ""
        'cmbClasificacion.SelectedIndex = -1
        'cmbSubClasificacion.SelectedIndex = -1
        'CB_ContactEmploye.SelectedIndex = -1
        'cmbEstado.SelectedIndex = -1
        'cmbFechaAdquisicion.SelectedIndex = -1
        'cmbValorAdquisicion.SelectedIndex = -1
        'txtValorAdquisicion.Text = ""
        'cmbVidaUtil.SelectedIndex = -1

    End Sub

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

    Private Sub cmbClasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClasificacion.SelectedIndexChanged

    End Sub

    Private Sub LlenaCbxSub(ByVal id_Company As Long, FixedAssetsType As Int64)

        _dtixedAssetsType_sub = objSql.GetFixedAssetsType_Sub(Data_Id_Company, FixedAssetsType)
        If _dtixedAssetsType_sub.Rows.Count > 0 Then
                cmbSubClasificacion.Enabled = True
                cmbSubClasificacion.SelectedIndex = -1
            Else
                cmbSubClasificacion.Enabled = False
                cmbSubClasificacion.Text = "Sin tipo"
                cmbSubClasificacion.SelectedIndex = -1
            End If
            cmbSubClasificacion.DataSource = _dtixedAssetsType_sub
            cmbSubClasificacion.ValueMember = "Id_FixedAssetsType_Sub"
            cmbSubClasificacion.DisplayMember = "Name_FixedAssetsType"
            cmbSubClasificacion.SelectedIndex = -1
            cmbSubClasificacion.Text = String.Empty

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

    Private Sub cmbClasificacion_DropDown(sender As Object, e As EventArgs) Handles cmbClasificacion.DropDown
        abierto = 0
    End Sub

    Private Sub cmbClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbClasificacion.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbClasificacion_DropDownClosed(sender As Object, e As EventArgs) Handles cmbClasificacion.DropDownClosed
        abierto = 1
    End Sub


    Private Sub cmbSubClasificacion_DropDown(sender As Object, e As EventArgs) Handles cmbSubClasificacion.DropDown
        abierto = 0
    End Sub

    Private Sub cmbSubClasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSubClasificacion.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbSubClasificacion_DropDownClosed(sender As Object, e As EventArgs) Handles cmbSubClasificacion.DropDownClosed
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Select Case IdReporte
            Case 0
                _MostrarFiltro = True
                _FiltradoPor = Filtro

                Dim fechaInicial As String = dtpFechaDesde.Value.ToString("yyyy-MM-dd")
                Dim fechaFinal As String = dtpFechaHasta.Value.ToString("yyyy-MM-dd")
                If (fechaInicial > fechaFinal) Then
                    MessageBox.Show("La fecha inicial es mayor que la final", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dtpFechaAdquisicion.Focus()
                Else
                    dt = objGeneric.ERP_GetBodyReportInventory_transfers(_ID_Company, fechaInicial, fechaFinal, Id_Clasificacion, Id_Sub_Clasificacion)
                End If

            Case 1
                _MostrarFiltro = True
                _FiltradoPor = Filtro
                If Not cmbEstado.SelectedIndex = -1 Then
                    dt = objGeneric.ERP_GetBodyReportFiexdAssetsState(cmbEstado.SelectedValue)
                Else
                    MessageBox.Show("Selecione un estado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cmbEstado.Focus()
                End If
            Case 2
                dt = objGeneric.ERP_GetBodyReportFiexdAssetsGeneral(_ID_Company, Codigo, NombreActivo, Id_Clasificacion, Id_Sub_Clasificacion, Id_estado_Fk, FechaAdquisicionInicial,
                                                                             FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, UbicacionPrimaria, UbicacionSecundaria, FechaDescargoInicial,
                                                                             FechaDescargoFinal, VidaUtilInicial, VidaUtilFinal)
                _MostrarFiltro = True
                _FiltradoPor = Filtro
            Case 3
                dt = objGeneric.ERP_GetBodyReportFiexdAssetstYPE(_ID_Company, Id_Clasificacion, Id_Sub_Clasificacion)
                _FiltradoPor = Filtro
                _MostrarFiltro = True
            Case 4
                dt = objGeneric.ERP_GetBodyReportFiexdAssetsGeneral(_ID_Company, Codigo, NombreActivo, Id_Clasificacion, Id_Sub_Clasificacion, Id_estado_Fk, FechaAdquisicionInicial, FechaAdquisicionFinal, RangoValorAdquisicionInicial, RangoValorAdquisicionFinal, UbicacionPrimaria, UbicacionSecundaria, FechaDescargoInicial, FechaDescargoFinal, VidaUtilInicial, VidaUtilFinal)
                Dim imagen As Bitmap
                Dim fileName As String = ""

                If dt.Rows.Count > 0 Then
                    Try
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
                    Catch ex As Exception

                    End Try


                End If
                _MostrarFiltro = True
                _FiltradoPor = Filtro
            Case 5
                dt = objGeneric.ERP_GetBodyReportFiexdAssetsGeneral(_ID_Company, Codigo, NombreActivo, Id_Clasificacion, Id_Sub_Clasificacion, Id_estado_Fk, FechaAdquisicionInicial, FechaAdquisicionFinal, ValorAdquisicionInicial, ValorAdquisicionFinal, UbicacionPrimaria, UbicacionSecundaria, FechaDescargoInicial, FechaDescargoFinal, VidaUtilInicial, VidaUtilFinal, Id_Employee)
                _MostrarFiltro = True
                _FiltradoPor = Filtro
            Case 6
                _FiltradoPor = Filtro
                _MostrarFiltro = True

                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo(UbicacionPrimaria, UbicacionSecundaria, UnidadOrganizativa, Id_Employee, Id_Clasificacion, Id_Sub_Clasificacion)
                End Using
            Case 7
                _FiltradoPor = Filtro
                _MostrarFiltro = True

                Using Obj As New Operaciones_SQLServer
                    dt = Obj.SP_ERP_Inventory_Ficha_Resumida_Activo(UbicacionPrimaria, UbicacionSecundaria, UnidadOrganizativa, Id_Employee, Id_Clasificacion, Id_Sub_Clasificacion)
                End Using

            Case Else
                MessageBox.Show("Seleccione un tipo de reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cb_Reporte.Focus()
        End Select
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        PnProcesando.Visible = False
        Dim objPartidaContable As Financiero_ReportViewer
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
                            Try
                                My.Computer.FileSystem.DeleteDirectory(folder, FileIO.DeleteDirectoryOption.DeleteAllContents)
                            Catch ex As Exception

                            End Try
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
                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.Ficha_Resumida_ActivoSeguro.rdlc")
                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
            Case 7
                objPartidaContable = New Financiero_ReportViewer(dt, "DataSet1", "epd_SatelliteERP.ReporteGeneralActivoFijo.rdlc")
                objPartidaContable.StartPosition = FormStartPosition.CenterScreen
            Case Else
                MessageBox.Show("Seleccione un tipo de reporte", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cb_Reporte.Focus()
        End Select
        Try
            objPartidaContable.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_UbicaconPrimaria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_UbicaconPrimaria.SelectedIndexChanged
        If (cmb_UbicaconPrimaria.SelectedIndex > 0) Then
            Dim _dtLocation As New DataTable
            _dtLocation = objSqlHumanResources.GetLocationByPrimary(Data_Id_Company, cmb_UbicaconPrimaria.SelectedValue)
            cmb_UbicaconSecundaria.DataSource = _dtLocation
            cmb_UbicaconSecundaria.DisplayMember = "Name_Location"
            cmb_UbicaconSecundaria.ValueMember = "Id_Location"
            cmb_UbicaconSecundaria.SelectedIndex = -1
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
    End Sub

    Private Sub lstClasificacion2_MouseClick(sender As Object, e As MouseEventArgs) Handles lstClasificacion2.MouseClick
        If Not lstClasificacion2.SelectedItems(0) = "" Then
            Dim Datos() As String = lstClasificacion2.SelectedItems(0).ToString.Split("||")
            LlenaCbxSub(Data_Id_Company, Convert.ToInt64(Datos(2)))
        End If
    End Sub
#End Region

End Class