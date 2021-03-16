Imports System.IO

Public Class ModuloProyectos
    Private objOperacion As New Operaciones_SQLServer
    Private _tableConfigBilling As DataTable
    Private _tableInvoiceHeader As DataTable
    Private Sub tcMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcMain.SelectedIndexChanged
        If sender.SelectedTab.Name = "Proyectos" Then
            GetDataProyectos()


        End If
    End Sub
    Private Sub GetDataProyectos()
        _tableInvoiceHeader = objOperacion.GetInvoiceProjectTransaction(Data_Id_Company)
        DGW_FacturasLista.AutoGenerateColumns = False
        DGW_FacturasLista.Font = New Font("Segoe UI", 11)
        DGW_FacturasLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        DGW_FacturasLista.ReadOnly = True
        DGW_FacturasLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGW_FacturasLista.MultiSelect = False

        DGW_FacturasLista.AllowUserToResizeColumns = False
        DGW_FacturasLista.AllowUserToAddRows = False
        DGW_FacturasLista.AllowUserToDeleteRows = False
        DGW_FacturasLista.Columns(0).Width = 1000
        DGW_FacturasLista.Columns(1).Width = 70
        DGW_FacturasLista.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_FacturasLista.Columns(2).Width = 90
        DGW_FacturasLista.Columns(3).Width = 160
        DGW_FacturasLista.Columns(4).Width = 220
        DGW_FacturasLista.Columns(5).Width = 120
        DGW_FacturasLista.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGW_FacturasLista.Columns(6).Width = 120
        DGW_FacturasLista.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGW_FacturasLista.Columns(6).DefaultCellStyle.Format = "#.##%"

        DGW_FacturasLista.DataSource = _tableInvoiceHeader
    End Sub

    Private Sub DGW_FacturasLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGW_FacturasLista.CellContentClick

    End Sub

End Class
