<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class metro_Lateral
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
        Me.PanelFondo = New System.Windows.Forms.Panel()
        Me.LabelCaption = New System.Windows.Forms.Label()
        Me.PictureFondo = New System.Windows.Forms.PictureBox()
        Me.PanelFondo.SuspendLayout()
        CType(Me.PictureFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFondo
        '
        Me.PanelFondo.BackColor = System.Drawing.Color.Crimson
        Me.PanelFondo.Controls.Add(Me.LabelCaption)
        Me.PanelFondo.Controls.Add(Me.PictureFondo)
        Me.PanelFondo.Location = New System.Drawing.Point(2, 0)
        Me.PanelFondo.Name = "PanelFondo"
        Me.PanelFondo.Size = New System.Drawing.Size(103, 90)
        Me.PanelFondo.TabIndex = 19
        '
        'LabelCaption
        '
        Me.LabelCaption.AutoSize = True
        Me.LabelCaption.BackColor = System.Drawing.Color.Transparent
        Me.LabelCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCaption.ForeColor = System.Drawing.Color.White
        Me.LabelCaption.Location = New System.Drawing.Point(3, 64)
        Me.LabelCaption.Name = "LabelCaption"
        Me.LabelCaption.Size = New System.Drawing.Size(101, 17)
        Me.LabelCaption.TabIndex = 0
        Me.LabelCaption.Text = "Cuentas-cobrar"
        '
        'PictureFondo
        '
        Me.PictureFondo.BackColor = System.Drawing.Color.Transparent
        Me.PictureFondo.Image = Global.epd_SatelliteERP.My.Resources.Resources.finansas2
        Me.PictureFondo.Location = New System.Drawing.Point(24, 24)
        Me.PictureFondo.Name = "PictureFondo"
        Me.PictureFondo.Size = New System.Drawing.Size(51, 37)
        Me.PictureFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureFondo.TabIndex = 3
        Me.PictureFondo.TabStop = False
        '
        'metro_Lateral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelFondo)
        Me.Name = "metro_Lateral"
        Me.Size = New System.Drawing.Size(106, 90)
        Me.PanelFondo.ResumeLayout(False)
        Me.PanelFondo.PerformLayout()
        CType(Me.PictureFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PanelFondo As Panel
    Private WithEvents LabelCaption As Label
    Private WithEvents PictureFondo As PictureBox
End Class
