Public Class Operacion_Procesos
    Private Sub metroSalir_Load(sender As Object, e As EventArgs) Handles metroSalir.EventClick
        Close()
    End Sub
    Property tabControl As Integer
    'Private Sub Metro_Proyectos_EventClick(sender As Object, e As EventArgs)
    '    PanelTrabajo.Controls.Clear()
    '    Dim obj As New ModuloProyectos

    '    obj.Dock = DockStyle.Fill
    '    PanelTrabajo.Controls.Add(obj)
    'End Sub

    Private Sub Operacion_Procesos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Metro_LateralInventario_EventClick(sender, e)
    End Sub

    Private Sub Metro_LateralInventario_EventClick(sender As Object, e As EventArgs) Handles Metro_LateralInventario.EventClick
        PanelTrabajo.Controls.Clear()

        If (tabControl > 0) Then
            Dim obj As New ModuloInventarios
            obj.tabControl = tabControl
            obj.Dock = DockStyle.Fill
            obj.AplicarRoles()
            PanelTrabajo.Controls.Add(obj)
        Else
            Dim obj As New ModuloInventarios
            obj.Dock = DockStyle.Fill
            obj.AplicarRoles()
            PanelTrabajo.Controls.Add(obj)
        End If

    End Sub

    Private Sub minimizar_EventClick(sender As Object, e As EventArgs) Handles minimizar.EventClick
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

End Class