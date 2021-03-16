<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Actividades
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelActividad = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.PB_Estado = New System.Windows.Forms.PictureBox()
        Me.LabelDescripcion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PB_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelActividad
        '
        Me.LabelActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActividad.Location = New System.Drawing.Point(55, 3)
        Me.LabelActividad.Name = "LabelActividad"
        Me.LabelActividad.Size = New System.Drawing.Size(146, 27)
        Me.LabelActividad.TabIndex = 0
        Me.LabelActividad.Text = "Actividad"
        Me.LabelActividad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelFecha
        '
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(3, 88)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(203, 18)
        Me.LabelFecha.TabIndex = 1
        Me.LabelFecha.Text = "Fecha"
        Me.LabelFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PB_Estado
        '
        Me.PB_Estado.Image = Global.epd_SatelliteERP.My.Resources.Resources.Amarillo_bandera
        Me.PB_Estado.Location = New System.Drawing.Point(-1, -1)
        Me.PB_Estado.Name = "PB_Estado"
        Me.PB_Estado.Size = New System.Drawing.Size(52, 32)
        Me.PB_Estado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Estado.TabIndex = 2
        Me.PB_Estado.TabStop = False
        '
        'LabelDescripcion
        '
        Me.LabelDescripcion.Location = New System.Drawing.Point(-2, 40)
        Me.LabelDescripcion.Name = "LabelDescripcion"
        Me.LabelDescripcion.Size = New System.Drawing.Size(203, 46)
        Me.LabelDescripcion.TabIndex = 3
        Me.LabelDescripcion.Text = "Descripcion"
        Me.LabelDescripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(2, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 2)
        Me.Panel1.TabIndex = 4
        '
        'UC_Actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelDescripcion)
        Me.Controls.Add(Me.PB_Estado)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.LabelActividad)
        Me.Name = "UC_Actividades"
        Me.Size = New System.Drawing.Size(204, 104)
        CType(Me.PB_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelActividad As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents PB_Estado As PictureBox
    Friend WithEvents LabelDescripcion As Label
    Friend WithEvents Panel1 As Panel
End Class
