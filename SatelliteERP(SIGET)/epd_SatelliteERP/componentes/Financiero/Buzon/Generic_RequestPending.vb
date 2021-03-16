Public Class Generic_RequestPending

	Private _DT_Check As New DataTable
	Private _DT_CxC As New DataTable
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub

	Private Sub Generic_RequestPending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LoadCxC()
	End Sub

	Public Sub LoadCxC()
		FLPCxC.Controls.Clear()
		Using objSQl As New Financiero_SQLServer
			_DT_CxC = objSQl.ERP_Finance_Request()
		End Using
		If Not _DT_CxC Is Nothing Then
			If _DT_CxC.Rows.Count > 0 Then
				For Each row As DataRow In _DT_CxC.Rows
					Dim obj As New CxC(Me)
					obj.LoadData(row("ID_Request"), row("Fecha"), row("Ammount"), row("Description_Credit"), row("DescriptionCatalog"), row("Empleado"), row("Cliente"), row("Commentary"))
					FLPCxC.Controls.Add(obj)
				Next row
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