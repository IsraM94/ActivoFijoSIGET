Public Class UC_Actividades
    Public Property ColorFondo As Color
        Get
            Return BackColor
        End Get
        Set(value As Color)
            BackColor = value
        End Set
    End Property
    Public Property NombreActividad As String
        Get
            Return LabelActividad.Text
        End Get
        Set(value As String)
            LabelActividad.Text = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return LabelDescripcion.Text
        End Get
        Set(value As String)
            LabelDescripcion.Text = value
        End Set
    End Property
    Public Property PictureActidad As Image
        Get
            Return PB_Estado.Image
        End Get
        Set(value As Image)
            PB_Estado.Image = value
        End Set
    End Property
    Public Property Fecha As String
        Get
            Return LabelFecha.Text
        End Get
        Set(value As String)
            LabelFecha.Text = value
        End Set
    End Property
End Class
