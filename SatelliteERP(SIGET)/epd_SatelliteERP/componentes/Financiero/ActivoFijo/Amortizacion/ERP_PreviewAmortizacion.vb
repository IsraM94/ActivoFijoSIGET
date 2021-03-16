Public Class ERP_PreviewAmortizacion

    Property _DSPreviewData As DataTable

    Private Sub ERP_PreviewDepreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgPreview.AutoGenerateColumns = False
        dgPreview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgPreview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgPreview.ReadOnly = True
        dgPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgPreview.MultiSelect = False
        dgPreview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgPreview.AllowUserToAddRows = False
        dgPreview.AllowUserToDeleteRows = False
        dgPreview.DataSource = _DSPreviewData
        Try
            lblTotal.Text = _DSPreviewData.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class