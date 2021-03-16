Public Class Generic_DataRequest

	Private _DT_Employee As New DataTable
	Private _DT_Catalog As New DataTable
	'--------------------------------------------------
	Property ID_Catalog As Long = 0
	Property ID_Employee As Long = 0
	Property Commentary As String = ""


	Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
		If cbType.SelectedIndex = -1 Then
			MessageBox.Show("Por favor seleccione el Tipo de Solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		If cb_Employee.SelectedIndex = -1 Then
			MessageBox.Show("Por favor seleccione el empleado que realiza la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		If txtDescripcion.Text.Trim = "" Then
			MessageBox.Show("Por favor ingrese un comentario para la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			txtDescripcion.Select()
			Exit Sub
		End If
		ID_Catalog = cbType.SelectedValue
		ID_Employee = cb_Employee.SelectedValue
		Commentary = txtDescripcion.Text.Trim
		Me.DialogResult = DialogResult.OK
		Me.Close()
	End Sub

	Private Sub LoadEmployee()
		Using objGeneric As New Generic_SQLServer
			_DT_Employee = objGeneric.GetEmployee(_ID_Company)
		End Using
		If Not _DT_Employee Is Nothing Then
			If _DT_Employee.Rows.Count > 0 Then
				cb_Employee.DataSource = _DT_Employee
				cb_Employee.ValueMember = "id_employee"
				cb_Employee.DisplayMember = "Contact"
				cb_Employee.SelectedIndex = -1
			End If
		End If
	End Sub

	Private Sub LoadCatalog()
		Using objGeneric As New Financiero_SQLServer
			_DT_Catalog = objGeneric.ERP_AccountsReceivable_GET_PartialPaymentsCatalog(_ID_Company)
		End Using
		If Not _DT_Catalog Is Nothing Then
			If _DT_Catalog.Rows.Count > 0 Then
				cbType.DataSource = _DT_Catalog
				cbType.ValueMember = "ID_Catalog"
				cbType.DisplayMember = "DescriptionCatalog"
				cbType.SelectedIndex = -1
			End If
		End If
	End Sub

	Private Sub Generic_DataRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadEmployee()
		LoadCatalog()
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