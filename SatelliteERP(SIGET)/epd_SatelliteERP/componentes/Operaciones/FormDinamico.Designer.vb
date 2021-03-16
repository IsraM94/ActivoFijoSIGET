<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDinamico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.PnObject = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PnObject
        '
        Me.PnObject.AutoScroll = True
        Me.PnObject.BackColor = System.Drawing.SystemColors.Control
        Me.PnObject.Location = New System.Drawing.Point(12, 12)
        Me.PnObject.Name = "PnObject"
        Me.PnObject.Size = New System.Drawing.Size(660, 502)
        Me.PnObject.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(565, 520)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 29)
        Me.btnCancelar.TabIndex = 32
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'FormDinamico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PnObject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDinamico"
        Me.Text = "Ingreso de Información"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnObject As Panel
    Private WithEvents btnCancelar As Button
End Class
