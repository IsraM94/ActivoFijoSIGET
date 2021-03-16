<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Especificacion
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
        Me.lblEtiqueta = New System.Windows.Forms.Label()
        Me.txtInformacion = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.AutoSize = True
        Me.lblEtiqueta.Location = New System.Drawing.Point(3, 0)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblEtiqueta.Size = New System.Drawing.Size(289, 13)
        Me.lblEtiqueta.TabIndex = 0
        Me.lblEtiqueta.Text = "Ejemplo Viñeta Llenado Prueba Para ingreso de informacion"
        '
        'txtInformacion
        '
        Me.txtInformacion.Location = New System.Drawing.Point(298, 3)
        Me.txtInformacion.Name = "txtInformacion"
        Me.txtInformacion.Size = New System.Drawing.Size(182, 20)
        Me.txtInformacion.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblEtiqueta)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtInformacion)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(615, 26)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'UC_Especificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "UC_Especificacion"
        Me.Size = New System.Drawing.Size(615, 26)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEtiqueta As Label
    Friend WithEvents txtInformacion As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
