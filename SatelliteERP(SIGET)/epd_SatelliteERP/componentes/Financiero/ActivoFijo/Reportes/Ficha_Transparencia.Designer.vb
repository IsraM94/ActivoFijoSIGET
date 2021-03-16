<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficha_Transparencia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdEnviar = New System.Windows.Forms.Button()
        Me.label49 = New System.Windows.Forms.Label()
        Me.txtMontoAdquisicion = New System.Windows.Forms.TextBox()
        Me.cmb_TipoActivo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmb_TipoActivo)
        Me.GroupBox1.Controls.Add(Me.txtMontoAdquisicion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar)
        Me.GroupBox1.Controls.Add(Me.cmdEnviar)
        Me.GroupBox1.Controls.Add(Me.label49)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 215)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccciona filtro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(24, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Monto Adquisición:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.BorderSize = 0
        Me.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Location = New System.Drawing.Point(338, 169)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(98, 29)
        Me.cmdCancelar.TabIndex = 30
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdEnviar
        '
        Me.cmdEnviar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdEnviar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.cmdEnviar.FlatAppearance.BorderSize = 0
        Me.cmdEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdEnviar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviar.Location = New System.Drawing.Point(221, 169)
        Me.cmdEnviar.Name = "cmdEnviar"
        Me.cmdEnviar.Size = New System.Drawing.Size(98, 29)
        Me.cmdEnviar.TabIndex = 29
        Me.cmdEnviar.Text = "Continuar"
        Me.cmdEnviar.UseVisualStyleBackColor = False
        '
        'label49
        '
        Me.label49.AutoSize = True
        Me.label49.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.label49.Location = New System.Drawing.Point(85, 57)
        Me.label49.Name = "label49"
        Me.label49.Size = New System.Drawing.Size(115, 25)
        Me.label49.TabIndex = 20
        Me.label49.Text = "Tipo Activo: "
        '
        'txtMontoAdquisicion
        '
        Me.txtMontoAdquisicion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMontoAdquisicion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoAdquisicion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoAdquisicion.Location = New System.Drawing.Point(206, 99)
        Me.txtMontoAdquisicion.MaxLength = 8
        Me.txtMontoAdquisicion.Name = "txtMontoAdquisicion"
        Me.txtMontoAdquisicion.Size = New System.Drawing.Size(298, 26)
        Me.txtMontoAdquisicion.TabIndex = 35
        '
        'cmb_TipoActivo
        '
        Me.cmb_TipoActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoActivo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmb_TipoActivo.FormattingEnabled = True
        Me.cmb_TipoActivo.Location = New System.Drawing.Point(206, 54)
        Me.cmb_TipoActivo.Name = "cmb_TipoActivo"
        Me.cmb_TipoActivo.Size = New System.Drawing.Size(307, 33)
        Me.cmb_TipoActivo.TabIndex = 36
        '
        'Ficha_Transparencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(543, 242)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ficha_Transparencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha_Transparencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents Label1 As Label
    Private WithEvents cmdCancelar As Button
    Private WithEvents cmdEnviar As Button
    Private WithEvents label49 As Label
    Private WithEvents txtMontoAdquisicion As TextBox
    Friend WithEvents cmb_TipoActivo As ComboBox
End Class
