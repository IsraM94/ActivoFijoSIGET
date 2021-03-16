Public Class Production_SacrificeDetails

	Property ID_Animal As Long = 0
	Property NameAnimal As String = ""
	Property PesoAnimal As Double = 0
	Property TipoAnimal As Long = 0
	Property NameTipoAnimal As String = ""
	Property Checked As Boolean = False
	Property IS_Product As Boolean = False

	Private _TipoAnimals As New DataTable

	Property IS_Father As Boolean = False
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
		If Not IS_Father Then
			If txtPeso.Text.Trim = "" Then
				MessageBox.Show("Por favor ingrese el peso del animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Exit Sub
			End If
			If Not IsNumeric(txtPeso.Text.Trim) Then
				MessageBox.Show("Por favor ingrese el peso del animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Exit Sub
			End If
			If Not IS_Product Then
				If cbTipoAnimal.SelectedIndex = -1 Then
					MessageBox.Show("Por favor ingrese el tipo de animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
					Exit Sub
				End If
			Else
				chkSalida.Checked = True
			End If
		Else
			If cbTipoAnimal.SelectedIndex = -1 Then
				MessageBox.Show("Por seleccione un Barraco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
				Exit Sub
			End If
		End If
		If Not IS_Father Then
			PesoAnimal = txtPeso.Text.Trim
		End If
		TipoAnimal = cbTipoAnimal.SelectedValue ' tambien tiene el id del Barraco
		NameTipoAnimal = cbTipoAnimal.Text
		If chkSalida.Checked Then
			Checked = True
		Else
			Checked = False
		End If
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub Production_SacrificeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If IS_Father Then
			Dim dt As New DataTable
			Using objsql As New Operaciones_SQLServer
				dt = objsql.ERP_Prod_SP_Select_Animal(0, 0)
			End Using
			cbTipoAnimal.DataSource = dt
			cbTipoAnimal.DisplayMember = "name"
			cbTipoAnimal.ValueMember = "ID"
			cbTipoAnimal.SelectedIndex = -1

			GroupBox1.Text = "Inseminación"
			txtNameAnimal.Visible = False
			txtPeso.Visible = False
			Label1.Visible = False
			chkSalida.Text = "Inseminar"
			chkSalida.Location = New Point(108, 83)
			cbTipoAnimal.Location = New Point(108, 36)
			cmdprint.Location = New Point(134, 126)
			cmdCancel.Location = New Point(238, 126)
			GroupBox1.Size = New Size(446, 165)
			Label2.Location = New Point(33, 36)
			Label2.Text = "Padre"
			Me.Size = New Size(466, 186)
		Else
			_TipoAnimals.Columns.Add("ID", Type.GetType("System.Int64"))
			_TipoAnimals.Columns.Add("name", Type.GetType("System.String"))
			_TipoAnimals.Rows.Add(1, "Pequeño")
			_TipoAnimals.Rows.Add(2, "Mediano")
			_TipoAnimals.Rows.Add(3, "Grande")
			cbTipoAnimal.DataSource = _TipoAnimals
			cbTipoAnimal.DisplayMember = "name"
			cbTipoAnimal.ValueMember = "ID"
			cbTipoAnimal.SelectedIndex = -1
			txtNameAnimal.Text = NameAnimal
			txtPeso.Text = PesoAnimal.ToString
			cbTipoAnimal.SelectedValue = TipoAnimal
			chkSalida.Checked = Checked
			If IS_Product Then
				cbTipoAnimal.Visible = False
				Label2.Visible = False
				GroupBox1.Text = "Total Producción"
				chkSalida.Visible = False
			End If
		End If

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