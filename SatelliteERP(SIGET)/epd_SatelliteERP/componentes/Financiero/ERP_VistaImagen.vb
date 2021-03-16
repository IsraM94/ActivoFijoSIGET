Public Class ERP_VistaImagen

    Public imagen As New PictureBox
    Private objSql As New Financiero_SQLServer
    Property idFKimage As Long
    Property id_FixedAsset_FK As Long

    Private Sub ERP_VistaImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxImagen.Image = imagen.Image
    End Sub

    Private Sub btnEliminarImagen_Click(sender As Object, e As EventArgs) Handles btnEliminarImagen.Click
        Dim mensaje As String = "¿Está seguro(a) que quiere eliminar la imagen?"

        If MessageBox.Show(mensaje, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If objSql.ERP_FixedAssets_Masterimage_Delete(idFKimage, id_FixedAsset_FK) = "OK" Then
                DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Error en eliminación de imagen.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        Close()
    End Sub

    Private Sub ERP_VistaImagen_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta <= 0 Then
                If pbxImagen.Width < 50 Then Exit Sub 'minumo tamaño
            Else
                If pbxImagen.Width > 1000 Then Exit Sub 'maximo tamaño
            End If
            pbxImagen.Width += CInt(pbxImagen.Width * e.Delta / 1000)
            pbxImagen.Height += CInt(pbxImagen.Height * e.Delta / 1000)
        End If
    End Sub

    Private Sub ERP_VistaImagen_Move(sender As Object, e As EventArgs) Handles Me.Move
        pbxImagen.Select()
    End Sub

    Private Sub ERP_VistaImagen_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        pbxImagen.Select()
        pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
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