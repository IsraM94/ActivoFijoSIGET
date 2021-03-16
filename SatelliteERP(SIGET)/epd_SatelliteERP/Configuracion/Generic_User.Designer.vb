<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Generic_User
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ContenedorPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuLateral = New System.Windows.Forms.FlowLayoutPanel()
        Me.metroSalir = New epd_SatelliteERP.metro_Lateral()
        Me.Metro_Mantenimientos = New epd_SatelliteERP.metro_Lateral()
        Me.Metro_Lateral1 = New epd_SatelliteERP.metro_Lateral()
        Me.PanelTrabajo = New System.Windows.Forms.Panel()
        Me.minimizar = New epd_SatelliteERP.metro_Lateral()
        Me.ContenedorPrincipal.SuspendLayout()
        Me.MenuLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContenedorPrincipal
        '
        Me.ContenedorPrincipal.ColumnCount = 2
        Me.ContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.ContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 639.0!))
        Me.ContenedorPrincipal.Controls.Add(Me.MenuLateral, 0, 0)
        Me.ContenedorPrincipal.Controls.Add(Me.PanelTrabajo, 1, 0)
        Me.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenedorPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ContenedorPrincipal.Name = "ContenedorPrincipal"
        Me.ContenedorPrincipal.RowCount = 1
        Me.ContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ContenedorPrincipal.Size = New System.Drawing.Size(776, 502)
        Me.ContenedorPrincipal.TabIndex = 1
        '
        'MenuLateral
        '
        Me.MenuLateral.AutoScroll = True
        Me.MenuLateral.Controls.Add(Me.metroSalir)
        Me.MenuLateral.Controls.Add(Me.Metro_Mantenimientos)
        Me.MenuLateral.Controls.Add(Me.Metro_Lateral1)
        Me.MenuLateral.Controls.Add(Me.minimizar)
        Me.MenuLateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuLateral.Location = New System.Drawing.Point(3, 3)
        Me.MenuLateral.Name = "MenuLateral"
        Me.MenuLateral.Size = New System.Drawing.Size(131, 496)
        Me.MenuLateral.TabIndex = 0
        '
        'metroSalir
        '
        Me.metroSalir.CaptionButton = "Regresar"
        Me.metroSalir.ColorFondo = System.Drawing.Color.LightSeaGreen
        Me.metroSalir.ImagenFondo = Global.epd_SatelliteERP.My.Resources.Resources.appbar_power
        Me.metroSalir.Location = New System.Drawing.Point(4, 4)
        Me.metroSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.metroSalir.Name = "metroSalir"
        Me.metroSalir.Size = New System.Drawing.Size(106, 90)
        Me.metroSalir.TabIndex = 0
        '
        'Metro_Mantenimientos
        '
        Me.Metro_Mantenimientos.CaptionButton = "Acceso Usuario"
        Me.Metro_Mantenimientos.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Metro_Mantenimientos.ImagenFondo = Global.epd_SatelliteERP.My.Resources.Resources.recursosHumanos
        Me.Metro_Mantenimientos.Location = New System.Drawing.Point(4, 102)
        Me.Metro_Mantenimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.Metro_Mantenimientos.Name = "Metro_Mantenimientos"
        Me.Metro_Mantenimientos.Size = New System.Drawing.Size(106, 90)
        Me.Metro_Mantenimientos.TabIndex = 1
        '
        'Metro_Lateral1
        '
        Me.Metro_Lateral1.CaptionButton = "Historico"
        Me.Metro_Lateral1.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Metro_Lateral1.ImagenFondo = Global.epd_SatelliteERP.My.Resources.Resources.recursosHumanos
        Me.Metro_Lateral1.Location = New System.Drawing.Point(4, 200)
        Me.Metro_Lateral1.Margin = New System.Windows.Forms.Padding(4)
        Me.Metro_Lateral1.Name = "Metro_Lateral1"
        Me.Metro_Lateral1.Size = New System.Drawing.Size(106, 90)
        Me.Metro_Lateral1.TabIndex = 2
        '
        'PanelTrabajo
        '
        Me.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTrabajo.Location = New System.Drawing.Point(140, 3)
        Me.PanelTrabajo.Name = "PanelTrabajo"
        Me.PanelTrabajo.Size = New System.Drawing.Size(633, 496)
        Me.PanelTrabajo.TabIndex = 1
        '
        'minimizar
        '
        Me.minimizar.CaptionButton = "   Minimizar"
        Me.minimizar.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.minimizar.ImagenFondo = Global.epd_SatelliteERP.My.Resources.Resources.minimizar
        Me.minimizar.Location = New System.Drawing.Point(4, 298)
        Me.minimizar.Margin = New System.Windows.Forms.Padding(4)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(106, 90)
        Me.minimizar.TabIndex = 7
        '
        'Generic_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 502)
        Me.Controls.Add(Me.ContenedorPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Generic_User"
        Me.Text = "Generic_Process"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContenedorPrincipal.ResumeLayout(False)
        Me.MenuLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContenedorPrincipal As TableLayoutPanel
    Friend WithEvents MenuLateral As FlowLayoutPanel
    Friend WithEvents metroSalir As metro_Lateral
    Friend WithEvents Metro_Mantenimientos As metro_Lateral
    Friend WithEvents PanelTrabajo As Panel
    Friend WithEvents Metro_Lateral1 As metro_Lateral
    Friend WithEvents minimizar As metro_Lateral
End Class
