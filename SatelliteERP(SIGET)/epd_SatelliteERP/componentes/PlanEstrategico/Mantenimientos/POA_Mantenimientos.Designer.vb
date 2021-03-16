<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POA_Mantenimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POA_Mantenimientos))
        Me.ContenedorPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuLateral = New System.Windows.Forms.FlowLayoutPanel()
        Me.metroSalir = New epd_SatelliteERP.metro_Lateral()
        Me.pnlFilosofia = New epd_SatelliteERP.metro_Lateral()
        Me.pnlPei = New epd_SatelliteERP.metro_Lateral()
        Me.pnlPoa = New epd_SatelliteERP.metro_Lateral()
        Me.pnlMapaRiesgo = New epd_SatelliteERP.metro_Lateral()
        Me.pnlDocumentacion = New epd_SatelliteERP.metro_Lateral()
        Me.minimizar = New epd_SatelliteERP.metro_Lateral()
        Me.PanelTrabajo = New System.Windows.Forms.Panel()
        Me.ContenedorPrincipal.SuspendLayout()
        Me.MenuLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContenedorPrincipal
        '
        Me.ContenedorPrincipal.ColumnCount = 2
        Me.ContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.ContenedorPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 852.0!))
        Me.ContenedorPrincipal.Controls.Add(Me.MenuLateral, 0, 0)
        Me.ContenedorPrincipal.Controls.Add(Me.PanelTrabajo, 1, 0)
        Me.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContenedorPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ContenedorPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContenedorPrincipal.Name = "ContenedorPrincipal"
        Me.ContenedorPrincipal.RowCount = 1
        Me.ContenedorPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ContenedorPrincipal.Size = New System.Drawing.Size(1035, 618)
        Me.ContenedorPrincipal.TabIndex = 1
        '
        'MenuLateral
        '
        Me.MenuLateral.AutoScroll = True
        Me.MenuLateral.Controls.Add(Me.metroSalir)
        Me.MenuLateral.Controls.Add(Me.pnlFilosofia)
        Me.MenuLateral.Controls.Add(Me.pnlPei)
        Me.MenuLateral.Controls.Add(Me.pnlPoa)
        Me.MenuLateral.Controls.Add(Me.pnlMapaRiesgo)
        Me.MenuLateral.Controls.Add(Me.pnlDocumentacion)
        Me.MenuLateral.Controls.Add(Me.minimizar)
        Me.MenuLateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuLateral.Location = New System.Drawing.Point(4, 4)
        Me.MenuLateral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MenuLateral.Name = "MenuLateral"
        Me.MenuLateral.Size = New System.Drawing.Size(175, 610)
        Me.MenuLateral.TabIndex = 0
        '
        'metroSalir
        '
        Me.metroSalir.CaptionButton = "Regresar"
        Me.metroSalir.ColorFondo = System.Drawing.Color.LightSeaGreen
        Me.metroSalir.ImagenFondo = CType(resources.GetObject("metroSalir.ImagenFondo"), System.Drawing.Bitmap)
        Me.metroSalir.Location = New System.Drawing.Point(5, 5)
        Me.metroSalir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.metroSalir.Name = "metroSalir"
        Me.metroSalir.Size = New System.Drawing.Size(141, 111)
        Me.metroSalir.TabIndex = 0
        '
        'pnlFilosofia
        '
        Me.pnlFilosofia.CaptionButton = "Filosofia Inst"
        Me.pnlFilosofia.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlFilosofia.ImagenFondo = Global.epd_SatelliteERP.My.Resources.Resources.recursosHumanos
        Me.pnlFilosofia.Location = New System.Drawing.Point(5, 126)
        Me.pnlFilosofia.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnlFilosofia.Name = "pnlFilosofia"
        Me.pnlFilosofia.Size = New System.Drawing.Size(141, 111)
        Me.pnlFilosofia.TabIndex = 4
        '
        'pnlPei
        '
        Me.pnlPei.CaptionButton = "Modulo PEI"
        Me.pnlPei.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlPei.ImagenFondo = CType(resources.GetObject("pnlPei.ImagenFondo"), System.Drawing.Bitmap)
        Me.pnlPei.Location = New System.Drawing.Point(5, 247)
        Me.pnlPei.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnlPei.Name = "pnlPei"
        Me.pnlPei.Size = New System.Drawing.Size(141, 111)
        Me.pnlPei.TabIndex = 1
        '
        'pnlPoa
        '
        Me.pnlPoa.CaptionButton = "Modulo POA"
        Me.pnlPoa.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlPoa.ImagenFondo = CType(resources.GetObject("pnlPoa.ImagenFondo"), System.Drawing.Bitmap)
        Me.pnlPoa.Location = New System.Drawing.Point(5, 368)
        Me.pnlPoa.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnlPoa.Name = "pnlPoa"
        Me.pnlPoa.Size = New System.Drawing.Size(141, 111)
        Me.pnlPoa.TabIndex = 2
        '
        'pnlMapaRiesgo
        '
        Me.pnlMapaRiesgo.CaptionButton = "Mapa de Riesgo"
        Me.pnlMapaRiesgo.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlMapaRiesgo.ImagenFondo = CType(resources.GetObject("pnlMapaRiesgo.ImagenFondo"), System.Drawing.Bitmap)
        Me.pnlMapaRiesgo.Location = New System.Drawing.Point(5, 489)
        Me.pnlMapaRiesgo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnlMapaRiesgo.Name = "pnlMapaRiesgo"
        Me.pnlMapaRiesgo.Size = New System.Drawing.Size(141, 111)
        Me.pnlMapaRiesgo.TabIndex = 3
        '
        'pnlDocumentacion
        '
        Me.pnlDocumentacion.CaptionButton = "Documentación"
        Me.pnlDocumentacion.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlDocumentacion.ImagenFondo = CType(resources.GetObject("pnlDocumentacion.ImagenFondo"), System.Drawing.Bitmap)
        Me.pnlDocumentacion.Location = New System.Drawing.Point(5, 610)
        Me.pnlDocumentacion.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pnlDocumentacion.Name = "pnlDocumentacion"
        Me.pnlDocumentacion.Size = New System.Drawing.Size(141, 111)
        Me.pnlDocumentacion.TabIndex = 8
        '
        'minimizar
        '
        Me.minimizar.CaptionButton = "   Minimizar"
        Me.minimizar.ColorFondo = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.minimizar.ImagenFondo = Global.epd_SatelliteERP.My.Resources.Resources.minimizar
        Me.minimizar.Location = New System.Drawing.Point(5, 731)
        Me.minimizar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(141, 111)
        Me.minimizar.TabIndex = 9
        '
        'PanelTrabajo
        '
        Me.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTrabajo.Location = New System.Drawing.Point(187, 4)
        Me.PanelTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTrabajo.Name = "PanelTrabajo"
        Me.PanelTrabajo.Size = New System.Drawing.Size(844, 610)
        Me.PanelTrabajo.TabIndex = 1
        '
        'POA_Mantenimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 618)
        Me.Controls.Add(Me.ContenedorPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "POA_Mantenimientos"
        Me.Text = "Generic_Process"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContenedorPrincipal.ResumeLayout(False)
        Me.MenuLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContenedorPrincipal As TableLayoutPanel
    Friend WithEvents MenuLateral As FlowLayoutPanel
    Friend WithEvents metroSalir As metro_Lateral
    Friend WithEvents pnlPei As metro_Lateral
    Friend WithEvents PanelTrabajo As Panel
    Friend WithEvents pnlPoa As metro_Lateral
    Friend WithEvents pnlMapaRiesgo As metro_Lateral
    Friend WithEvents pnlFilosofia As metro_Lateral
    Friend WithEvents pnlDocumentacion As metro_Lateral
    Friend WithEvents minimizar As metro_Lateral
End Class
