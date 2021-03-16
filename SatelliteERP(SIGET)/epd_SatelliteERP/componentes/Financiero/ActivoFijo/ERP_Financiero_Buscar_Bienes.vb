Public Class ERP_Financiero_Buscar_Bienes
    Private objSqlGeneric As New Generic_SQLServer
    Property idResponsable As Integer
    Property ID As String
    Private Sub ERP_Financiero_Buscar_Bienes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgv_Bienes.DataSource = objSqlGeneric.Generic_FromXLS_GetBienes(idResponsable)

        If dgv_Bienes.Rows.Count > 0 Then

        Else

            MessageBox.Show("No tienen bienes")
            Close()
        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dgv_Bienes.DataSource = objSqlGeneric.Generic_FromXLS_GetBienes(idResponsable, txtBuscar.Text.ToString())

    End Sub

    Private Sub dgv_Bienes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Bienes.CellClick
        ID = dgv_Bienes.CurrentRow.Cells(1).Value
        DialogResult = DialogResult.OK

        Close()
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