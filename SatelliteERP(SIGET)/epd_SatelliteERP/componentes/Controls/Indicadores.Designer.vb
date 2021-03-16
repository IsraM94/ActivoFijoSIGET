<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Indicadores
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMaximoDias = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSeleccionados = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPromedioDias = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtCiclo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.pbIndicador = New System.Windows.Forms.PictureBox()
        Me.pbGroup = New System.Windows.Forms.PictureBox()
        CType(Me.pbIndicador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Seleccionados:"
        '
        'lblMaximoDias
        '
        Me.lblMaximoDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximoDias.Location = New System.Drawing.Point(207, 73)
        Me.lblMaximoDias.Name = "lblMaximoDias"
        Me.lblMaximoDias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaximoDias.Size = New System.Drawing.Size(39, 13)
        Me.lblMaximoDias.TabIndex = 1
        Me.lblMaximoDias.Text = "none"
        Me.lblMaximoDias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Maximo Dias:"
        '
        'lblSeleccionados
        '
        Me.lblSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionados.Location = New System.Drawing.Point(207, 97)
        Me.lblSeleccionados.Name = "lblSeleccionados"
        Me.lblSeleccionados.Size = New System.Drawing.Size(39, 13)
        Me.lblSeleccionados.TabIndex = 3
        Me.lblSeleccionados.Text = "none"
        Me.lblSeleccionados.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Promedio Dias:"
        '
        'lblPromedioDias
        '
        Me.lblPromedioDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedioDias.Location = New System.Drawing.Point(207, 121)
        Me.lblPromedioDias.Name = "lblPromedioDias"
        Me.lblPromedioDias.Size = New System.Drawing.Size(39, 13)
        Me.lblPromedioDias.TabIndex = 5
        Me.lblPromedioDias.Text = "none"
        Me.lblPromedioDias.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No Total Animales:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(207, 145)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "none"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCiclo
        '
        Me.txtCiclo.Enabled = False
        Me.txtCiclo.Location = New System.Drawing.Point(59, 13)
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.ReadOnly = True
        Me.txtCiclo.Size = New System.Drawing.Size(199, 20)
        Me.txtCiclo.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Ciclo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Grupo:"
        '
        'txtGrupo
        '
        Me.txtGrupo.Enabled = False
        Me.txtGrupo.Location = New System.Drawing.Point(59, 37)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(199, 20)
        Me.txtGrupo.TabIndex = 11
        '
        'pbIndicador
        '
        Me.pbIndicador.Image = Global.epd_SatelliteERP.My.Resources.Resources.Rojo
        Me.pbIndicador.Location = New System.Drawing.Point(264, 7)
        Me.pbIndicador.Name = "pbIndicador"
        Me.pbIndicador.Size = New System.Drawing.Size(59, 50)
        Me.pbIndicador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIndicador.TabIndex = 14
        Me.pbIndicador.TabStop = False
        '
        'pbGroup
        '
        Me.pbGroup.Location = New System.Drawing.Point(3, 63)
        Me.pbGroup.Name = "pbGroup"
        Me.pbGroup.Size = New System.Drawing.Size(65, 47)
        Me.pbGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGroup.TabIndex = 13
        Me.pbGroup.TabStop = False
        '
        'Indicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.pbIndicador)
        Me.Controls.Add(Me.pbGroup)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtGrupo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCiclo)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblPromedioDias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSeleccionados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMaximoDias)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Indicadores"
        Me.Size = New System.Drawing.Size(325, 163)
        CType(Me.pbIndicador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMaximoDias As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSeleccionados As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPromedioDias As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
	Friend WithEvents txtCiclo As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents txtGrupo As TextBox
	Friend WithEvents pbGroup As PictureBox
	Friend WithEvents pbIndicador As PictureBox
End Class
