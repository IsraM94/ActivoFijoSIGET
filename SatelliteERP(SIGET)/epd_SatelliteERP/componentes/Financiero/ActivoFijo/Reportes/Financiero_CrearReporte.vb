Public Class Financiero_CrearReporte
    Private objSql As New Financiero_SQLServer
    Private _tableGenericReport As DataTable
    Private objDatos As New Generic_SQLServer
    Private _DT_Filtros As New DataTable
    Private _DT_Deparment As New DataTable
    Private _DT_Boss As New DataTable
    Property Id_Reporte As Integer
    Private Sub Financiero_CrearReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelFecha.Visible = False
        PanelID.Visible = False
        pnlDepartamento.Visible = False
        loadData()
    End Sub


    Private Sub loadData()
        _DT_Filtros.Columns.Add("ID")
        _DT_Filtros.Columns.Add("Nombre")
        _DT_Filtros.Rows.Add(1, "Departamento")
        _DT_Filtros.Rows.Add(2, "Responsable")
        _DT_Filtros.Rows.Add(3, "Rango de fechas")

        RemoveHandler CB_Location.SelectedIndexChanged, AddressOf CB_Location_SelectedIndexChanged
        CB_Location.DataSource = _DT_Filtros
        CB_Location.DisplayMember = "Nombre"
        CB_Location.ValueMember = "ID"
        CB_Location.SelectedIndex = -1

        AddHandler CB_Location.SelectedIndexChanged, AddressOf CB_Location_SelectedIndexChanged

        _tableGenericReport = objSql.ERP_RRHH_GetGenericReportHeader()
        cb_Reporte.DataSource = _tableGenericReport
        cb_Reporte.DisplayMember = "Name_Header"
        cb_Reporte.ValueMember = "Id_Header"
        cb_Reporte.SelectedIndex = -1
    End Sub

    Private Sub CB_Location_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Not CB_Location.SelectedIndex = -1 Then
            If CB_Location.SelectedValue = 1 Then 'Departamento
                pnlDepartamento.Visible = True
                PanelID.Visible = False
                PanelFecha.Visible = False
                _DT_Deparment = objDatos.GetDepartment(Data_Id_Company)
                If Not _DT_Deparment Is Nothing Then
                    cmbDepartmento.DataSource = _DT_Deparment
                    cmbDepartmento.DisplayMember = "Name_Deparmnet"
                    cmbDepartmento.ValueMember = "Id_Deparment"
                    cmbDepartmento.SelectedIndex = -1
                End If
            ElseIf CB_Location.SelectedValue = 2 Then 'Persona
                PanelID.Visible = True
                pnlDepartamento.Visible = False
                PanelFecha.Visible = False
                _DT_Boss = objDatos.GetEmployee(1)
                If Not _DT_Boss Is Nothing Then
                    cmb_persona.DataSource = _DT_Boss
                    cmb_persona.DisplayMember = "contact"
                    cmb_persona.ValueMember = "Id_employee"
                    cmb_persona.SelectedIndex = -1
                End If

            ElseIf CB_Location.SelectedValue = 3 Then 'Fecha
                PanelFecha.Visible = True
                pnlDepartamento.Visible = False
                PanelID.Visible = False
            End If
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If Not cb_Reporte.SelectedIndex = -1 Then
            Dim TituloReporte As String
            Dim datosPresentacion As New DataTable
            Dim _DT_DataReporte As New DataTable

            Id_Reporte = cb_Reporte.SelectedValue.ToString

            Using objSQL As New Generic_SQLServer
                TituloReporte = objSQL.ERP_Generic_GetTituloReporte(_ID_Company, Id_Reporte).Rows(0)(0).ToString
                datosPresentacion = objSQL.ERP_Generic_GetHeaderReport(_ID_Company, Id_Reporte)
                _DT_DataReporte = objSQL.ERP_Generic_GetBodyReportData(_ID_Company)
            End Using
            Dim drows() As DataRow
            Dim dt As New DataTable
            Try
                If CB_Location.SelectedValue = 1 Then
                    drows = _DT_DataReporte.Select("Id_Department_FK = " + cmbDepartmento.SelectedValue.ToString)
                ElseIf CB_Location.SelectedValue = 2 Then
                    drows = _DT_DataReporte.Select("Id_ResponsiblePerson_FK = " + cmb_persona.SelectedValue.ToString)
                ElseIf CB_Location.SelectedValue = 3 Then
                    Dim fechaInicial As String = dtpFechaInicial.Value.ToString("yyyy-MM-dd")
                    Dim fechaFinal As String = dtpFechaFinal.Value.ToString("yyyy-MM-dd")
                    drows = _DT_DataReporte.Select("Date_Acquisition >= '" + fechaInicial + "' and Date_Acquisition <= '" + fechaFinal + "'")
                End If
                If Not drows.Count < 1 Then
                    dt = drows.CopyToDataTable()
                End If
                If dt.Rows.Count > 0 Then
                    Using objGenerador As New ReportProccesor
                        objGenerador.GenerarReporte(dt, datosPresentacion, TituloReporte)
                    End Using
                Else
                    MessageBox.Show("No hay datos que mostrar")
                End If

            Catch ex As Exception
                MessageBox.Show("No hay Registros que mostrar")
            End Try
        Else
            MessageBox.Show("Seleccione un reporte")
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
#End Region

End Class