Public Class Reporting_Field
    Enum AlingType As Integer
        Rigth
        Left
        Center
    End Enum

    Property TypeControl As String
    Property Font As Font
    Property X As Integer
    Property Y As Integer
    Property Aling As StringAlignment
    Property Color As Color
End Class
