Public Class Inventario_fechasEntregados
    Public Property Fechainicio As Date
    Public Property FechaFin As Date
    Public Property _IdCategoria As Integer
    Public Property _ID_Stowage As Integer
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Fechainicio = dtpFechainicio.Value
        FechaFin = dtpFechafin.Value
        _IdCategoria = cbxProducto.SelectedValue
        If dtpFechainicio.Value > dtpFechafin.Value Then
            MessageBox.Show("La fecha inicio no debe se mayor a la fecha fin", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.DialogResult = DialogResult.OK
        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub Inventario_fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using obj As New Operaciones_SQLServer
            Dim _dtMarca As New DataTable
            _dtMarca = obj.ERP_Inventory_GetProducts_Category(Data_Id_Company)
            cbxProducto.DataSource = _dtMarca
            cbxProducto.DisplayMember = "nombrecat"
            cbxProducto.ValueMember = "id"
        End Using

    End Sub

    Public Event DropDownOpened As EventHandler

    Private abierto As Integer = 1
    Private abierto2 As Integer = 1
    Private Sub cbxProducto_DropDown(sender As Object, e As EventArgs) Handles cbxProducto.DropDown
        abierto = 0
    End Sub

    Private Sub cbxProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxProducto.KeyPress
        If (abierto = 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxProducto_DropDownClosed(sender As Object, e As EventArgs) Handles cbxProducto.DropDownClosed
        abierto = 1
    End Sub
End Class