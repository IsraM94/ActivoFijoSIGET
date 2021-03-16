Public Class Production_Quantity

	Property NameProduct As String = ""
	Property Quantity As Double = 0

	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
		If txtQuantity.Text.Trim = "" Then
            MessageBox.Show("Por favor ingrese la cantidad producida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtQuantity.Select()
			Exit Sub
		End If
		If Not IsNumeric(txtQuantity.Text.Trim) Then
            MessageBox.Show("Por favor ingrese la cantidad producida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtQuantity.Select()
			Exit Sub
		End If
		Quantity = txtQuantity.Text.Trim
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Production_Quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtName.Text = NameProduct
		txtQuantity.Text = Quantity
	End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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