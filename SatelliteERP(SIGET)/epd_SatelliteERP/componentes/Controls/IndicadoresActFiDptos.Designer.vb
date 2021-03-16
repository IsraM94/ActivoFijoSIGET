<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IndicadoresActFiDptos
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTransferidos = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSinTransferencia = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pbIndicador = New System.Windows.Forms.PictureBox()
        Me.pbGroup = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.pbIndicador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total en Proceso"
        '
        'lblTransferidos
        '
        Me.lblTransferidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferidos.Location = New System.Drawing.Point(199, 77)
        Me.lblTransferidos.Name = "lblTransferidos"
        Me.lblTransferidos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTransferidos.Size = New System.Drawing.Size(53, 24)
        Me.lblTransferidos.TabIndex = 1
        Me.lblTransferidos.Text = "none"
        Me.lblTransferidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Transferidos"
        '
        'lblProceso
        '
        Me.lblProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProceso.Location = New System.Drawing.Point(199, 111)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(53, 24)
        Me.lblProceso.TabIndex = 3
        Me.lblProceso.Text = "none"
        Me.lblProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total sin Transferencia"
        '
        'lblSinTransferencia
        '
        Me.lblSinTransferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinTransferencia.Location = New System.Drawing.Point(199, 144)
        Me.lblSinTransferencia.Name = "lblSinTransferencia"
        Me.lblSinTransferencia.Size = New System.Drawing.Size(53, 20)
        Me.lblSinTransferencia.TabIndex = 5
        Me.lblSinTransferencia.Text = "none"
        Me.lblSinTransferencia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total de Activos"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(199, 181)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(53, 20)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "none"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Enabled = False
        Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.Location = New System.Drawing.Point(12, 35)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(327, 29)
        Me.txtDepartamento.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Departamento"
        '
        'pbIndicador
        '
        Me.pbIndicador.Image = Global.epd_SatelliteERP.My.Resources.Resources.alerts
        Me.pbIndicador.Location = New System.Drawing.Point(254, 78)
        Me.pbIndicador.Name = "pbIndicador"
        Me.pbIndicador.Size = New System.Drawing.Size(28, 27)
        Me.pbIndicador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIndicador.TabIndex = 14
        Me.pbIndicador.TabStop = False
        '
        'pbGroup
        '
        Me.pbGroup.Location = New System.Drawing.Point(250, 177)
        Me.pbGroup.Name = "pbGroup"
        Me.pbGroup.Size = New System.Drawing.Size(65, 47)
        Me.pbGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGroup.TabIndex = 13
        Me.pbGroup.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.epd_SatelliteERP.My.Resources.Resources.Amarillo
        Me.PictureBox1.Location = New System.Drawing.Point(254, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.epd_SatelliteERP.My.Resources.Resources.Rojo
        Me.PictureBox2.Location = New System.Drawing.Point(254, 144)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'IndicadoresActFiDptos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbIndicador)
        Me.Controls.Add(Me.pbGroup)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSinTransferencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblProceso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTransferidos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IndicadoresActFiDptos"
        Me.Size = New System.Drawing.Size(357, 209)
        CType(Me.pbIndicador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTransferidos As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProceso As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSinTransferencia As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pbGroup As PictureBox
    Friend WithEvents pbIndicador As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
