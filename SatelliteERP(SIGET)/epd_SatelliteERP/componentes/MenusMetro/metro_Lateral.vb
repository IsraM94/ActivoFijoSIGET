Public Class metro_Lateral
    Private _CaptionButton As String = "SubMenu"
    Private _ColorFondo As Color = Color.Red
    Private _ImagenFondo As Bitmap = epd_SatelliteERP.My.Resources.Resources.finansas2
    Public Event EventClick(sender As Object, e As EventArgs)
    Public Property CaptionButton As String
        Get
            Return _CaptionButton
        End Get
        Set(value As String)
            _CaptionButton = value
            LabelCaption.Text = _CaptionButton
        End Set
    End Property
    Public Property ColorFondo As Color
        Get
            Return _ColorFondo
        End Get
        Set(value As Color)
            _ColorFondo = value
            PanelFondo.BackColor = _ColorFondo
        End Set
    End Property
    Public Property ImagenFondo As Bitmap
        Get
            Return _ImagenFondo
        End Get
        Set(value As Bitmap)
            _ImagenFondo = value
            PictureFondo.Image = _ImagenFondo
        End Set
    End Property
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureFondo.Click, PanelFondo.Click, LabelCaption.Click
        RaiseEvent EventClick(sender, e)
    End Sub
End Class
