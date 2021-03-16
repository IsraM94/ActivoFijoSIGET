Public Class Inventario_Saldo_Existencia
    Public Property Mes As String = ""
    Public Property Anyo As Integer = -1


    Private Sub cmdFiltrarSaldo_Click(sender As Object, e As EventArgs) Handles cmdFiltrarSaldo.Click
        Anyo = cmbAnio.SelectedIndex


        If cmbMes.SelectedIndex = -1 Then
            MessageBox.Show("Selecciones un mes", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        If Anyo = -1 Then
            MessageBox.Show("Selecciones un Año", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Mes = cmbMes.SelectedValue
        Anyo = cmbAnio.SelectedValue
        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub cmdFiltroCancel_Click(sender As Object, e As EventArgs) Handles cmdFiltroCancel.Click
        Me.Close()
    End Sub

    Private Sub LoadAnios()
        Dim dt As New DataTable
        Using objSQL As New Operaciones_SQLServer
            dt = objSQL.SP_ERP_Inventory_AniosBalance
        End Using
        cmbAnio.DataSource = dt
        cmbAnio.ValueMember = "Anio"
        cmbAnio.DisplayMember = "Anio"
        cmbAnio.SelectedIndex = -1
    End Sub

    Private Sub LoadMeses()
        Dim dt As New DataTable
        dt.Columns.Add("ID")
        dt.Columns.Add("Nombre")
        dt.Rows.Add("01", "Enero")
        dt.Rows.Add("02", "Febrero")
        dt.Rows.Add("03", "Marzo")
        dt.Rows.Add("04", "Abril")
        dt.Rows.Add("05", "Mayo")
        dt.Rows.Add("06", "Junio")
        dt.Rows.Add("07", "Julio")
        dt.Rows.Add("08", "Agosto")
        dt.Rows.Add("09", "Septiembre")
        dt.Rows.Add("10", "Octubre")
        dt.Rows.Add("11", "Noviembre")
        dt.Rows.Add("12", "Diciembre")

        cmbMes.DataSource = dt
        cmbMes.ValueMember = "ID"
        cmbMes.DisplayMember = "Nombre"
        cmbMes.SelectedIndex = -1
    End Sub

    Private Sub Inventario_Saldo_Existencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeses()
        LoadAnios()
    End Sub
End Class