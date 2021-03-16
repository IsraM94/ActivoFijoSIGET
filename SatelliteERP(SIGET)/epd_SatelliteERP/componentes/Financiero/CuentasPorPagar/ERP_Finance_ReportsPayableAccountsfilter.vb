Public Class ERP_Finance_ReportsPayableAccountsfilter
    Private objDatos As New Generic_SQLServer
    Private dtProveedores As DataTable
    Property movementType As Integer = 0
    Property Id_Provider As Long
    Property Name_Deparment As String
    Property fechainicio As Date
    Property fechafin As Date
    Property queryoption As Integer
    Private actualamount As Double

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub GetData()
        dtProveedores = objDatos.GetCustomerMaster(Data_Id_Company)

        cbProveedores.DataSource = dtProveedores
        cbProveedores.ValueMember = "Id_Customer"
        cbProveedores.DisplayMember = "Name_Company"

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim dt1 As DataTable
        Dim Ds As New EPD_SatelliteERPDataSet_PayableAccounts
        Dim reportName As String = ""
        Id_Provider = cbProveedores.SelectedValue

        If chk_RangoFechas.Checked = True Then
            If mcFechaFinal.Value <= mcFechaInicio.Value Then
                MessageBox.Show("Fecha inicio no puede ser mayor que fecha final", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                fechainicio = mcFechaInicio.Value
                fechafin = mcFechaFinal.Value
                If chk_TodoProveedores.Checked Then
                    queryoption = 2
                Else
                    queryoption = 4
                End If
            End If
        Else
            If chk_TodoProveedores.Checked Then
                queryoption = 1
            Else
                queryoption = 3
            End If
        End If


        Dim dt As New EPD_SatelliteERPDataSet_PayableAccountsTableAdapters.ERP_AP_ReportAccountsPayableTableAdapter
        dt.Fill(Ds.ERP_AP_ReportAccountsPayable, Data_Id_Company, Id_Provider, queryoption, fechainicio, fechafin)
        dt1 = Ds.Tables(0)
        reportName = "epd_SatelliteERP.Reports_PayableAccounts.rdlc"

        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DsAccountsPayable", reportName)
            objPartidaContable.ShowDialog()
        End Using
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub ERP_Finance_Bank_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub chk_SeleccionarBancos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_SeleccionarProveedores.CheckedChanged
        If cbProveedores.Enabled = False Then
            cbProveedores.Enabled = True
        Else
            cbProveedores.Enabled = False
        End If
    End Sub

    Private Sub chk_RangoFechas_CheckedChanged(sender As Object, e As EventArgs) Handles chk_RangoFechas.CheckedChanged
        If mcFechaInicio.Enabled = False Then
            mcFechaInicio.Enabled = True
            mcFechaFinal.Enabled = True
        Else
            mcFechaInicio.Enabled = False
            mcFechaFinal.Enabled = False
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