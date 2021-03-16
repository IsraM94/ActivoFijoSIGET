Public Class EditarRequisicion
    Private _DT_Stowage As New DataTable
    Property ID_Stowage As Long = 0
    Property Name_Stowage As String = ""

    Private _DT_Products As New DataTable
    Property ID_Producto As Long = 0

    Private Stock As String = ""
    Property bodega As Long = 0
    Property rowActual As DataRow

    Property cantidadentregada As Integer = 0
    Property observaciones As String = ""
    Private Sub EditarRequisucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCatalog()
        If Not rowActual Is Nothing Then
            NombreProducto.Text = rowActual("Name_Product")
            ExistenciasProducto.Text = Convert.ToDouble(rowActual("Stock_Product")).ToString("#0.00")
            CantidadSolicitada.Text = Convert.ToDouble(rowActual("RequiredQuantity")).ToString("#0.00")
            ID_Producto = rowActual("id_producto_fk")
            CantidadEntregar.Text = Convert.ToDouble(rowActual("SuppliedQuantity")).ToString("#0.00")
        Else
            ' registro no existe poner mensaje y salir

        End If
    End Sub

    Private Sub LoadCatalog()

        Using objSQL As New Operaciones_SQLServer
            _DT_Stowage = objSQL.ERP_Prod_SP_Select_StowageEmpty()
        End Using
        cb_Bodega1.DataSource = _DT_Stowage
        cb_Bodega1.ValueMember = "ID_Stowage"
        cb_Bodega1.DisplayMember = "Name_Stowage"
        cb_Bodega1.SelectedValue = bodega
    End Sub
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If CantidadEntregar.Text.Trim = "" Then
            MessageBox.Show("Ingrese la cantidad a entragar", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)


            Exit Sub
        End If
        'If Observacion.Text.Trim = "" Then
        '    MessageBox.Show("Ingrese la observación", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    Exit Sub
        'End If

        If CDec(CantidadEntregar.Text) > CDec(CantidadSolicitada.Text) Then
            MessageBox.Show("La cantidad ingresada es mayor a la que ha solicitado", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If

        ID_Stowage = cb_Bodega1.SelectedValue.ToString
        Name_Stowage = cb_Bodega1.Text
        cantidadentregada = CantidadEntregar.Text
        observaciones = Observacion.Text
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub cb_Bodega1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Bodega1.SelectedIndexChanged
        Try
            bodega = cb_Bodega1.SelectedValue.ToString
        Catch ex As Exception

        End Try


        If ID_Producto > 0 Then
            ' Dim resp As String =ObjSQl.Inventory_SelectStock(CType(bodega, Integer), ID_Producto)

            Using ObjSQl As New Requisiciones_SQLServer
                Stock = ObjSQl.Inventory_SelectStock(CType(bodega, Integer), ID_Producto)
                If IsNumeric(Stock) Then
                    ExistenciasProducto.Text = Stock

                ElseIf Stock.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error este producto tiene, " & Stock.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)


                End If

            End Using
        End If
        ' MessageBox.Show("los id son" + bodega)

    End Sub

    Private Sub CantidadEntregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadEntregar.KeyPress
        Using objValidaciones As New Validaciones
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = objValidaciones.Validar_Money(sender, e, CantidadEntregar)
            End If
        End Using
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
#End Region
End Class