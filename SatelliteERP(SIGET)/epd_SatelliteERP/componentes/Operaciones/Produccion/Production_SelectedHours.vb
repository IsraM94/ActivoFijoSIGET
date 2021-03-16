Public Class Production_SelectedHours

    Public Property IdProcess As Integer
    Public Property IdHours As Integer

    Private Sub Production_SelectedHours_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet

        Using objSql As New Produccion_SQLProcess
            ds = objSql.Production_GetHoursProcess(Data_Id_Company, IdProcess)
            cbHoursProcess.DataSource = ds.Tables("GetHours")
            cbHoursProcess.DisplayMember = "descrp"
            cbHoursProcess.ValueMember = "idDoc"
        End Using
    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        IdHours = cbHoursProcess.SelectedItem(0)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        IdHours = 0
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