Public Class ERP_Finance_ReportsBankPettyCashfilter
    Private objDatos As New Generic_SQLServer
    Private dtDepartment As DataTable
    Private _Id_Deparment As Long = 0
    Property ispettyCash As Boolean = False
    Property movementType As Integer = 0
    Property Id_Bank As Long
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
        If ispettyCash Then
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 1)
        Else
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 0)
        End If

        cbBancos.DataSource = dtDepartment
        cbBancos.ValueMember = "Id_BankCatalog"
        cbBancos.DisplayMember = "Name_BankCatalog"

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim dt1 As DataTable
        Dim Ds As New EPD_SatelliteERPDataSet_BankandPettyCashMovements
        Dim reportName As String = ""
        Id_Bank = cbBancos.SelectedValue

        If chk_RangoFechas.Checked = True Then
            If mcFechaInicio.Value > mcFechaFinal.Value Then
                MessageBox.Show("Fecha inicio no puede ser mayor que fecha final", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                fechainicio = mcFechaInicio.Value
                fechafin = mcFechaFinal.Value
                If chk_TodoBancos.Checked Then
                    queryoption = 2
                Else
                    queryoption = 4
                End If
            End If
        Else
            If chk_TodoBancos.Checked Then
                queryoption = 1
            Else
                queryoption = 3
            End If
        End If

        If ispettyCash Then
            Dim dt As New EPD_SatelliteERPDataSet_BankandPettyCashMovementsTableAdapters.ERP_Finance_ReportPettyCashMovementsTableAdapter
            dt.Fill(Ds.ERP_Finance_ReportPettyCashMovements, Data_Id_Company, Id_Bank, queryoption, fechainicio, fechafin)
            dt1 = Ds.Tables(1)
            reportName = "epd_SatelliteERP.Reports_PettyCashMovements.rdlc"
        Else
            Dim dt As New EPD_SatelliteERPDataSet_BankandPettyCashMovementsTableAdapters.ERP_Finance_ReportBankMovementsTableAdapter
            dt.Fill(Ds.ERP_Finance_ReportBankMovements, Data_Id_Company, Id_Bank, Queryoption, fechainicio, fechafin)
            dt1 = Ds.Tables(0)
            reportName = "epd_SatelliteERP.Reports_BankMovements.rdlc"
        End If

        Using objPartidaContable As New Financiero_ReportViewer(dt1, "DsMovements", reportName)
            objPartidaContable.ShowDialog()
        End Using






        'If txtDescription.Text <> "" Then
        '    If txtAmountMovement.Text <> "" Then
        '        If Id_Bank > 0 Then ' Es modificacion
        '            If ispettyCash = False Then
        '                If movementType = 2 Then
        '                    If txtAmountMovement.Text > actualamount Then
        '                        MessageBox.Show("El monto no puede ser mayor que el saldo actual del banco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    Else
        '                        If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, "", txtDescription.Text, txtAmountMovement.Text, False) = "OK" Then
        '                            DialogResult = DialogResult.OK
        '                            Close()
        '                        Else
        '                            MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                        End If
        '                    End If
        '                Else
        '                    If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, "", txtDescription.Text, txtAmountMovement.Text, False) = "OK" Then
        '                        DialogResult = DialogResult.OK
        '                        Close()
        '                    Else
        '                        MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    End If
        '                End If

        '            Else
        '                If movementType = 4 Then
        '                    If txtAmountMovement.Text > actualamount Then
        '                        MessageBox.Show("El monto no puede ser mayor que el saldo actual de caja chica", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    Else
        '                        If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, txtPagadoa.Text, txtDescription.Text, txtAmountMovement.Text, True) = "OK" Then
        '                            DialogResult = DialogResult.OK
        '                            Close()
        '                        Else
        '                            MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                        End If
        '                    End If
        '                Else
        '                    If objDatos.ERP_Finance_InsertBankMovements(Data_Id_Company, movementType, Id_Bank, txtPagadoa.text, txtDescription.Text, txtAmountMovement.Text, True) = "OK" Then
        '                        DialogResult = DialogResult.OK
        '                        Close()
        '                    Else
        '                        MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    End If

        '                End If
        '            End If

        '        Else
        '            MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        End If
        '    Else
        '        MessageBox.Show("Error, no puede dejar campos en blanco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Else
        '    MessageBox.Show("Error, no puede dejar campos en blanco", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub

    Private Sub txtNameBank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Not IsNumeric(e.KeyChar) And e.KeyChar <> vbBack And e.KeyChar <> "." Then
        '    e.Handled = True
        'End If

        'Using objValidaciones As New Validaciones
        '    If Not Char.IsControl(e.KeyChar) Then
        '        e.Handled = objValidaciones.Validar_Money(sender, e, txtAmountMovement)
        '    End If
        'End Using
    End Sub

    Private Sub cbBancos_SelectedvalueChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedValueChanged
        If ispettyCash Then
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 1)
        Else
            dtDepartment = objDatos.ERP_Finance_SelectBankBalance(Data_Id_Company, 0)
        End If
    End Sub

    Private Sub ERP_Finance_Bank_Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub chk_SeleccionarBancos_CheckedChanged(sender As Object, e As EventArgs) Handles chk_SeleccionarBancos.CheckedChanged
        If cbBancos.Enabled = False Then
            cbBancos.Enabled = True
        Else
            cbBancos.Enabled = False
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