Public Class frmImportDataXLS
    Private dtXLS As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ofdArchivoXls.ShowDialog() = DialogResult.OK Then
            txtFile.Text = ofdArchivoXls.FileName
            Using objHoja As New frmSeleccionarHojaXLS
                objHoja.filename = ofdArchivoXls.FileName
                If objHoja.ShowDialog() = DialogResult.OK Then
                    dtXLS = objHoja.infoXLS
                    dgvInfoXLS.DataSource = objHoja.infoXLS
                End If
            End Using
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objGeneric As New Generic_SQLServer
        Dim ret As Integer = objGeneric.Generic_FromXLS_Set(dtXLS)
        If Not ret = 0 Then
            objGeneric.Generic_ActualizaCatalogos_Legacy()
            MessageBox.Show("Proceso Finalizado")
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DialogResult = DialogResult.Cancel
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