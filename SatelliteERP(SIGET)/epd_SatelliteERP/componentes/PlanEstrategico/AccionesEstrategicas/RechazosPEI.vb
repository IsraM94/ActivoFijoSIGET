Public Class RechazosPEI

    Private objsql As New POA_SQLServer
    Private DtEstrategicas As New DataTable
    Private DtOperativas As New DataTable
    Property IdEncabezado As Integer = 0
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AlertaAcciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Using obj As New POA_SQLServer
            dt = obj.ERP_StrategicPlan_GetPEIObservaciones(IdEncabezado)
        End Using

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                DG_Rechazos.AutoGenerateColumns = False
                DG_Rechazos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                DG_Rechazos.Font = New Font("Segoe UI", 11)
                DG_Rechazos.RowHeadersVisible = False

                DG_Rechazos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DG_Rechazos.MultiSelect = False
                DG_Rechazos.DataSource = dt
                'DG_Rechazos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                DG_Rechazos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                DG_Rechazos.ScrollBars = ScrollBars.Both
                DG_Rechazos.ForeColor = Color.Black
                DG_Rechazos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
                DG_Rechazos.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            End If
        End If

    End Sub
End Class