Public Class POA_Mantenimientos
    Private Sub metroSalir_Click(sender As Object, e As EventArgs) Handles metroSalir.EventClick
        Close()
    End Sub
    Private Sub Metro_Mantenimientos_EventClick(sender As Object, e As EventArgs) Handles pnlPei.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloPEI
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub Generic_Process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Metro_Mantenimientos_EventClick(sender, e)
    End Sub

    Private Sub Metro_Filosofia(sender As Object, e As EventArgs) Handles pnlFilosofia.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloFilosofia
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub


    Private Sub Metro_Procesos(sender As Object, e As EventArgs) Handles pnlPoa.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloPOA
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub pnlDocumentacion_Click(sender As Object, e As EventArgs) Handles pnlDocumentacion.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloDocumentacion
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub MetroMapa_Click(sender As Object, e As EventArgs) Handles pnlMapaRiesgo.EventClick
        PanelTrabajo.Controls.Clear()
        Dim obj As New ModuloMapaRiesgo
        obj.Dock = DockStyle.Fill
        PanelTrabajo.Controls.Add(obj)
    End Sub

    Private Sub minimizar_EventClick(sender As Object, e As EventArgs) Handles minimizar.EventClick
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class