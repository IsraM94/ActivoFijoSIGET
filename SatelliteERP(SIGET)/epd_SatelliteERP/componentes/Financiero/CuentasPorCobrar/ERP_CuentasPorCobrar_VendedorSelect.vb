Imports System.Windows.Forms

Public Class ERP_CuentasPorCobrar_VendedorSelect

    Private _DT_Employees As DataTable = Nothing
    Public Sub ERP_CuentasPorCobrar_VendedorSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using objSQL As New Generic_SQLServer
            _DT_Employees = objSQL.GetContactEmploye(Data_Id_Company)
            If _DT_Employees IsNot Nothing Then
                cbVendedores.DataSource = _DT_Employees
                cbVendedores.DisplayMember = "Contact"
                cbVendedores.ValueMember = "Id_employee"
                cbVendedores.SelectedIndex = -1

            End If
        End Using
    End Sub


    Public Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        Dim idvendedor As Long = cbVendedores.SelectedValue
        Dim Ds As New DataTable
        Using obj As New Financiero_SQLServer
            Ds = obj.ReporteDeudaPorVendedor(Data_Id_Company, idvendedor)
        End Using

        REM  Dim dt1 As New EPD_SatelliteERPDeudasPorVendedorTableAdapters.ERP_AR_ReportDeudasPorVendedorTableAdapter
        REM dt1.Fill(Ds, idvendedor, Data_Id_Company)
        ' dt1 = Ds.Tables("ERP_SP_Inventory_Report_AccountStatus")
        Using obj As New Financiero_ReportViewer(Ds, "datos", "epd_SatelliteERP.Reporte_DeudasPorVendedor.rdlc")
            obj.WindowState = FormWindowState.Maximized
            obj.ShowDialog()
        End Using
    End Sub

    Public Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.Cancel
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

End Class
