<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StatusDiasVacio
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
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pbIndicador = New System.Windows.Forms.PictureBox()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtDias = New System.Windows.Forms.TextBox()
		CType(Me.pbIndicador, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(3, 20)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(115, 20)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Nombre Animal:"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(4, 3)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(114, 18)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Código Animal:"
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(4, 87)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(89, 24)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Días Vacío:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbIndicador
		'
		Me.pbIndicador.Image = Global.epd_SatelliteERP.My.Resources.Resources.Rojo
		Me.pbIndicador.Location = New System.Drawing.Point(245, 34)
		Me.pbIndicador.Name = "pbIndicador"
		Me.pbIndicador.Size = New System.Drawing.Size(59, 50)
		Me.pbIndicador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbIndicador.TabIndex = 15
		Me.pbIndicador.TabStop = False
		'
		'txtCodigo
		'
		Me.txtCodigo.Enabled = False
		Me.txtCodigo.Location = New System.Drawing.Point(113, 3)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(122, 20)
		Me.txtCodigo.TabIndex = 16
		Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtNombre
		'
		Me.txtNombre.Enabled = False
		Me.txtNombre.Location = New System.Drawing.Point(7, 43)
		Me.txtNombre.Multiline = True
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(228, 41)
		Me.txtNombre.TabIndex = 17
		'
		'txtDias
		'
		Me.txtDias.Enabled = False
		Me.txtDias.Location = New System.Drawing.Point(90, 91)
		Me.txtDias.Name = "txtDias"
		Me.txtDias.Size = New System.Drawing.Size(145, 20)
		Me.txtDias.TabIndex = 18
		Me.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'StatusDiasVacio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Controls.Add(Me.txtDias)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.pbIndicador)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Name = "StatusDiasVacio"
		Me.Size = New System.Drawing.Size(307, 117)
		CType(Me.pbIndicador, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label5 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents pbIndicador As PictureBox
	Friend WithEvents txtCodigo As TextBox
	Friend WithEvents txtNombre As TextBox
	Friend WithEvents txtDias As TextBox
End Class
