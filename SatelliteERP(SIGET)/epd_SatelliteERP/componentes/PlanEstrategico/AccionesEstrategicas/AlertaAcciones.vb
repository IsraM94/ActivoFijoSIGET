Public Class AlertaAcciones

    Private objsql As New POA_SQLServer
    Private DtEstrategicas As New DataTable
    Private DtOperativas As New DataTable



    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AlertaAcciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Using obj As New POA_SQLServer
            dt = obj.ERP_StrategicPlan_GetStrategicActionsAlert(_Id_DptoPlani)
            dt2 = obj.ERP_StrategicPlan_GetStrategicActionsAlertOperational(_Id_DptoPlani)
        End Using



        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then

                dgEstrategicas.AutoGenerateColumns = False
                dgEstrategicas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                dgEstrategicas.Font = New Font("Segoe UI", 11)
                dgEstrategicas.RowHeadersVisible = False

                dgEstrategicas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgEstrategicas.MultiSelect = False
                dgEstrategicas.DataSource = dt
            End If
        End If

        If Not IsNothing(dt2) Then
            If dt2.Rows.Count > 0 Then

                dgOperativas.AutoGenerateColumns = False
                dgOperativas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                dgOperativas.Font = New Font("Segoe UI", 11)
                dgOperativas.RowHeadersVisible = False

                dgOperativas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgOperativas.MultiSelect = False
                dgOperativas.DataSource = dt2
            End If
        End If
    End Sub
End Class