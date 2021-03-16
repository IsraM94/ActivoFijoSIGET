Public Class ERP_Inventory_Dialog_Quantity
    Dim objValidacion As New Validaciones
    Property row As DataRow
	Property Price As Double = 0
	Property Quantity As Double = 0
    Property Check As Boolean = False
    Property check1 As String = ""
    Property CheckIVA As Boolean = False
    Property CheckIVA1 As String = ""
    Property ID_Unit As Long = 0
    Property Unidad As String = ""
    Property DT_Unit As New DataTable
    Property NameProduct As String = ""

    Property _FechaVencimiento As Date
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub ERP_Inventory_Dialog_Quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cbUnidad.DataSource = DT_Unit
		cbUnidad.DisplayMember = "Name_UnitMeasure"
		cbUnidad.ValueMember = "Id_UnitMeasure"
        cbUnidad.SelectedIndex = -1
        txtProducto.Text = NameProduct.ToString.Trim
        If DT_Unit.Rows.Count = 1 Then
			cbUnidad.SelectedIndex = 0
            cbUnidad.Enabled = False
        End If
	End Sub

	Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        If txtCantidad.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese la cantidad", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtCantidad.Select()
            Exit Sub
        End If
        If cbUnidad.SelectedIndex = -1 Then
            MessageBox.Show("Por favor seleccione la unidad de medida para la entrada", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If
        If Not IsNumeric(txtCantidad.Text.Trim) Then
            MessageBox.Show("Por favor ingrese un valor numérico para la cantidad", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtCantidad.Select()
            Exit Sub
        End If
        If txtPrecio.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el precio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtPrecio.Select()
            Exit Sub
        End If
        If Not IsNumeric(txtPrecio.Text.Trim) Then
            MessageBox.Show("Por favor ingrese un valor numérico para el precio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtPrecio.Select()
            Exit Sub
        End If
        ID_Unit = cbUnidad.SelectedValue
        Unidad = cbUnidad.Text

        ' unidad ="Unidad"
        If chkUnitario.Checked Then
            Check = True
            check1 = "SI"

        Else
            Check = False
            check1 = "NO"
        End If
		If chkIncluyeIVA.Checked Then
            CheckIVA = True
            CheckIVA1 = "SI"
        Else
            CheckIVA = False
            CheckIVA1 = "NO"
        End If
		Price = txtPrecio.Text.Trim
        Quantity = txtCantidad.Text.Trim
        _FechaVencimiento = dtpFechaVencimiento.Value.ToString("yyyy-MM-dd")
        Me.DialogResult = DialogResult.OK
	End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.Handled = objValidacion.Validar_Money(sender, e, txtPrecio)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        e.Handled = objValidacion.Validar_Money(sender, e, txtCantidad)
    End Sub

    Private Sub GBSearch_Enter(sender As Object, e As EventArgs) Handles GBSearch.Enter

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