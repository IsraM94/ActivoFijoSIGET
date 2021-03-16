Public Class Configurar_Proveedores
    Dim contador As Integer = 1
    Dim point As New System.Drawing.Point
    Dim X, Y As Integer
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs)
        X = Control.MousePosition.X - sender.Location.X
        Y = Control.MousePosition.Y - sender.Location.Y
    End Sub
    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            point = Control.MousePosition
            point.X = point.X - (X)
            point.Y = point.Y - (Y)
            sender.Location = point
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objButtom As New Campo_DocumentoIdentidad
        objButtom.Text = "Hola Mundo " & contador.ToString
        PanelScreen.Controls.Add(objButtom)
        contador += 1
        AddHandler objButtom.MouseDown, AddressOf Me.Button1_MouseDown
        AddHandler objButtom.MouseMove, AddressOf Me.Button1_MouseMove
    End Sub

End Class