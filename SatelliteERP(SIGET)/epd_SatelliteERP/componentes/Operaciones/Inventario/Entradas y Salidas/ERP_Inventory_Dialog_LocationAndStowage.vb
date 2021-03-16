Public Class ERP_Inventory_Dialog_LocationAndStowage
	Private _DT_Location As New DataTable
	Private _DT_Stowage As New DataTable
	Public Property ID_Stowage As Long = 0
	Public Property Name_Stowage As String = ""
	Public Property NameLocation As String = ""
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.DialogResult = DialogResult.Cancel
		Me.Close()
	End Sub

	Private Sub ERP_Inventory_Dialog_LocationAndStowage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		fillLocation()
	End Sub

	Private Sub fillLocation()
		Using objSQL As New Operaciones_SQLServer
			_DT_Location = objSQL.SP_ERP_Inventory_GetLocation(_ID_Company)
		End Using
		If _DT_Location.Rows.Count > 0 Then
			RemoveHandler cbLocation.SelectedIndexChanged, AddressOf cbLocation_SelectedIndexChanged
			cbLocation.DataSource = _DT_Location
			cbLocation.DisplayMember = "NameLocation"
			cbLocation.ValueMember = "ID_Location"
			cbLocation.SelectedIndex = -1
			AddHandler cbLocation.SelectedIndexChanged, AddressOf cbLocation_SelectedIndexChanged
		End If
	End Sub

	Private Sub cbLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLocation.SelectedIndexChanged
		If Not cbLocation.SelectedIndex = -1 Then
			Dim ID_Location As Long = cbLocation.SelectedValue
			Using objSQl As New Operaciones_SQLServer
				_DT_Stowage = objSQl.SP_ERP_Inventory_GetStowage_ByLocation(ID_Location)
			End Using
			If _DT_Stowage.Rows.Count > 0 Then
				cbStowage.DataSource = _DT_Stowage
				cbStowage.DisplayMember = "Name_Stowage"
				cbStowage.ValueMember = "ID_Stowage"
				cbStowage.SelectedIndex = -1
			End If
		End If
	End Sub

	Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
		If cbLocation.SelectedIndex = -1 Then
			MessageBox.Show("Seleccione la ubicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		If cbStowage.SelectedIndex = -1 Then
			MessageBox.Show("Seleccione la bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End If
		ID_Stowage = cbStowage.SelectedValue
		Name_Stowage = cbStowage.Text
		NameLocation = cbLocation.Text
		Me.DialogResult = DialogResult.OK
		Me.Close()
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