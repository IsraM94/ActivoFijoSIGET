Public Class Fina_Procesos
    Private Sub metroSalir_Click(sender As Object, e As EventArgs) Handles metroSalir.EventClick
        Close()
    End Sub

    Private Sub Metro_Lateral1_Load(sender As Object, e As EventArgs) Handles metroSalir.Click
        Close()
    End Sub

    Private Sub Metro_ActivoFijo_EventClick(sender As Object, e As EventArgs) Handles Metro_ActivoFijo.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloActivoFijo

        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)


    End Sub

    Private Sub Fina_Procesos_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Metro_ActivoFijo.Enabled Then
            Metro_ActivoFijo_EventClick(sender, e)
        Else
            Metro_ActivoFijo_EventClick(sender, e)
        End If
    End Sub

    Private Sub minimizar_EventClick(sender As Object, e As EventArgs) Handles minimizar.EventClick
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

End Class