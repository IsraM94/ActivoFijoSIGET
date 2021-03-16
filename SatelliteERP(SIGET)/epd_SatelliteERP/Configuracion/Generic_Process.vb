Public Class Generic_Process
    Private Sub metroSalir_Click(sender As Object, e As EventArgs) Handles metroSalir.EventClick
        Close()
    End Sub
    Private Sub Metro_Mantenimientos_EventClick(sender As Object, e As EventArgs) Handles Metro_Mantenimientos.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloMantenimientos
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub Generic_Process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Metro_Mantenimientos_EventClick(sender, e)
    End Sub

    Private Sub Menu_ConfReportes_EventClick(sender As Object, e As EventArgs) Handles Menu_ConfReportes.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloConfiguracionReportes
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub minimizar_EventClick(sender As Object, e As EventArgs) Handles minimizar.EventClick
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class