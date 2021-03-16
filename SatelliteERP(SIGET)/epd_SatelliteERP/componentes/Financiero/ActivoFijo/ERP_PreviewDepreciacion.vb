Public Class ERP_PreviewDepreciacion

    Property _DSPreviewData As DataTable

    Private Sub ERP_PreviewDepreciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgPreview.AutoGenerateColumns = False
        dgPreview.Columns(0).Width = 100
        dgPreview.Columns(1).Width = 250
        dgPreview.Columns(2).Width = 100
        dgPreview.Columns(3).Width = 130
        dgPreview.Columns(4).Width = 130
        dgPreview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgPreview.Columns(5).Width = 150
        dgPreview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgPreview.Columns(6).Width = 150
        dgPreview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgPreview.Columns(7).Width = 200
        dgPreview.Columns(8).Width = 200
        dgPreview.Columns(9).Width = 200
        dgPreview.Columns(10).Width = 200
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