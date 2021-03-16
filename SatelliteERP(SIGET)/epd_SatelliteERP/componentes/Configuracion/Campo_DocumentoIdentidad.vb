Public Class Campo_DocumentoIdentidad
    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarToolStripMenuItem.Click
        Using obj As New Configurar_Campos
            obj.Descripcion = LabelCampo.Text
            If obj.ShowDialog() = DialogResult.OK Then
                LabelCampo.Text = obj.Descripcion
            End If
        End Using
    End Sub
End Class
