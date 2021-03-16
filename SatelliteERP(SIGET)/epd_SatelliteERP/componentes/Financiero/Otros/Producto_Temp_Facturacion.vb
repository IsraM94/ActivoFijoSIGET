Public Class Producto_Temp_Facturacion
    Property SalesAmount As Decimal
    Property Name_Product As String
    Property EsGrabado As Boolean = True
    Property UnidadMedida As String

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If Not txtNameProduct.Text.Length > 10 Then
            MessageBox.Show("Descripción tiene que ser mayor a diez caracteres..", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not IsNumeric(txtSaleAmount.Text) Then
            MessageBox.Show("Monto tiene que ser numérico", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cbUnit.SelectedIndex = -1 Then
            MessageBox.Show("Tiene que seleccionar Unidad de Medida", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        SalesAmount = txtSaleAmount.Text
        Name_Product = txtNameProduct.Text
        EsGrabado = CB_EsGrabado.Checked
        UnidadMedida = cbUnit.Text
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        DialogResult = DialogResult.None
        Close()
    End Sub
    Private Function filCBUnitMeasure() As Boolean
        Dim resp As Boolean = False
        Dim _DT_UnitMeasure As DataTable
        Using ObjSQL As New Operaciones_SQLServer
            _DT_UnitMeasure = ObjSQL.GetUnitMeasure(_ID_Company)
        End Using
        If _DT_UnitMeasure.Rows.Count <> 0 Then
            Try
                resp = True
                cbUnit.DataSource = _DT_UnitMeasure
                cbUnit.DisplayMember = "Name_UnitMeasure"
                cbUnit.ValueMember = "Id_UnitMeasure"
                cbUnit.SelectedIndex = -1
            Catch ex As ArgumentException
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            Catch ex As Exception
                Using ObjSQL As New Operaciones_SQLServer
                    ObjSQL.SaveLogException(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.Message.ToString)
                End Using
            End Try
        End If
        Return resp
    End Function

    Private Sub Producto_Temp_Facturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filCBUnitMeasure()
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