Public Class Manto_Monedas
    Private Sub Manto_Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.User.IsInRole("") Then
            MessageBox.Show("zzzz")
        End If
    End Sub
End Class