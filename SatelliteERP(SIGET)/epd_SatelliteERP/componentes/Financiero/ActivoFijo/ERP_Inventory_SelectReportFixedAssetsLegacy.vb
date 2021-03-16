Public Class ERP_Inventory_SelectReportFixedAssetsLegacy
    Private objDatos As New Generic_SQLServer
    Private objSQL As New HumanResources_SQLServer
    Private dtLinea As DataTable
    Private _dtComboCategorias As DataTable
    Property Id_Company_FK As Long
    Property Name_Linea As String
    Property id_Linea As Long = 0
    Property id_Categoria As Long = 0
    Property Title As String

    Private Sub Mantenimiento_Generic_Municipality_Load(sender As Object, e As EventArgs) Handles Me.Load
        _dtComboCategorias = objSQL.GetEmploye(Id_Company_FK)
        cmbEmpleados.DataSource = _dtComboCategorias
        cmbEmpleados.DisplayMember = "contact"
        cmbEmpleados.ValueMember = "Id_Employee"
        If id_Linea <> 0 Then
            'txtNameLinea.Text = Name_Linea
            gbElegirReporteEmpleados.Text = Title
            cmbEmpleados.SelectedValue = id_Categoria
        End If
    End Sub

    Private Sub cmdReporteInventario_Click(sender As Object, e As EventArgs) Handles cmdReporteInventario.Click
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_Finance_FixedAssetByEmploye(_ID_Company, cmbEmpleados.SelectedValue)
        End Using
        If dt.Rows.Count > 0 Then
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSetFixedAsster", "epd_SatelliteERP.Reporte_InventarioActivos.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        Else
            MessageBox.Show("El empleado seleccionado no cuenta con registro de activos", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub cmdReporteLegacy_Click(sender As Object, e As EventArgs) Handles cmdReporteLegacy.Click
        Dim dt As New DataTable
        Using objsql As New Financiero_SQLServer
            dt = objsql.ERP_Finance_FixedAssetByEmployeLegacy(_ID_Company, cmbEmpleados.SelectedValue)
        End Using
        If dt.Rows.Count > 0 Then
            Using objPartidaContable As New Financiero_ReportViewer(dt, "DataSetFixedAsster", "epd_SatelliteERP.Reporte_InventarioActivosLegacy.rdlc")
                objPartidaContable.ShowDialog()
            End Using
        Else
            MessageBox.Show("El empleado seleccionado no cuenta con registro de activos", "SatelliteERP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
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

    Private Sub gbElegirReporteEmpleados_Enter(sender As Object, e As EventArgs) Handles gbElegirReporteEmpleados.Enter

    End Sub
#End Region

End Class