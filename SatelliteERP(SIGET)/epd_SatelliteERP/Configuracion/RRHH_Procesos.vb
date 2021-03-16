Public Class RRHH_Procesos
    Private Sub metroSalir_Load(sender As Object, e As EventArgs) Handles metroSalir.EventClick
        Close()
    End Sub

    Private Sub Metro_Lateral3_EventClick(sender As Object, e As EventArgs) Handles Metro_Lateral3.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloRecursosHumanos()
        obj.Dock = DockStyle.Fill
        obj.AplicarRoles() REM ocultar Botones

        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub RRHH_Procesos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Metro_Lateral3_EventClick(sender, e)
    End Sub

    Private Sub minimizar_EventClick(sender As Object, e As EventArgs) Handles minimizar.EventClick
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

End Class