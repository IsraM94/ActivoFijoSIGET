Public Class UC_Especificacion

    Public Property Etiqueta() As String
        Get
            Return lblEtiqueta.Text
        End Get
        Set(ByVal value As String)
            lblEtiqueta.Text = value
        End Set
    End Property

    Public Property Informacion() As String
        Get
            Return txtInformacion.Text
        End Get
        Set(ByVal value As String)
            txtInformacion.Text = value
        End Set
    End Property
    Private _id_Type As String
    Public Property ID_Type() As String
        Get
            Return _id_Type
        End Get
        Set(ByVal value As String)
            _id_Type = value
        End Set
    End Property

    Private _ID_Fixed As Int64
    Public Property ID_Fixed() As Int64
        Get
            Return _ID_Fixed
        End Get
        Set(ByVal value As Int64)
            _ID_Fixed = value
        End Set
    End Property
    Private _ID_Fixed_Details As Int64
    Public Property ID_Fixed_Details() As Int64
        Get
            Return _ID_Fixed_Details
        End Get
        Set(ByVal value As Int64)
            _ID_Fixed_Details = value
        End Set
    End Property

    Private Sub lblEtiqueta_TextChanged(sender As Object, e As EventArgs) Handles lblEtiqueta.TextChanged
        Me.Width = lblEtiqueta.Width + txtInformacion.Width + 10
    End Sub
End Class
