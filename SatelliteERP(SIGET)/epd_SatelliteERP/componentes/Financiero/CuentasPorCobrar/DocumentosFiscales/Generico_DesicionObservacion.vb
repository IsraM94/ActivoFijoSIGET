Imports System.Windows.Forms

Public Class Generico_DesicionObservacion
    Property Observacion As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Observacion = txtObservacion.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Generico_DesicionObservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtObservacion.Text = Observacion
    End Sub
End Class
