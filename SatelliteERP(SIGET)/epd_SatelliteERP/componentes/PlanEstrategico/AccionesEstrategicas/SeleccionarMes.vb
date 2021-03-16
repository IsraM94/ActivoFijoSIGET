Public Class SeleccionarMes

#Region "Properties"
    Private objsql As New POA_SQLServer
    Property MesReportado As String = ""
    Property IdMesReportado As Integer = 0
#End Region

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        MesReportado = comboMeses.SelectedItem(1).ToString
        IdMesReportado = comboMeses.SelectedItem(0).ToString
        DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub SeleccionarAnio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dataInfo As DataTable = objsql.ERP_StrategicPlan_getMeses

            Dim dataSelect As DataTable = dataInfo.Clone

            For Each Info As DataRow In dataInfo.Rows
                dataSelect.ImportRow(Info)
            Next

            comboMeses.DataSource = dataSelect
            comboMeses.DisplayMember = "Mes"
            comboMeses.ValueMember = "IdMEs"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class