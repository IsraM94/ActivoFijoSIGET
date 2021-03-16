Public Class ERP_Inventory_Dialog_CreateSubProduct
	Enum Process
		add
		update
	End Enum

	Property TipoProceso As Process = Process.add
	Property NameProduct As String = ""
	Property PriceProduct As Double = 0

	Private Sub ERP_Inventory_Dialog_CreateSubProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If TipoProceso = Process.update Then
			GBSearch.Text = "Actualizar Sub Producto"
			txtName.Text = NameProduct
			txtPrice.Text = PriceProduct.ToString
		End If
	End Sub

	Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
		If txtName.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el nombre del subproducto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtName.Select()
			Exit Sub
		End If
		If txtPrice.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese el precio del subproducto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPrice.Select()
			Exit Sub
		End If
		If Not IsNumeric(txtPrice.Text.Trim) Then
            MessageBox.Show("Por favor ingrese el precio del subproducto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtPrice.Select()
			Exit Sub
		End If
		NameProduct = txtName.Text
		PriceProduct = txtPrice.Text
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
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